# Recombee API Client

A .NET client (SDK) for easy use of the [Recombee](https://www.recombee.com/) recommendation API.

If you don't have an account at Recombee yet, you can create a free account [here](https://www.recombee.com/).

Documentation of the API can be found at [docs.recombee.com](https://docs.recombee.com/).

## Installation

To install Recombee.ApiClient, run the following command in the Package Manager Console
```
Install-Package Recombee.ApiClient
```

## Examples

### Basic example

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using Recombee.ApiClient;
using Recombee.ApiClient.ApiRequests;
using Recombee.ApiClient.Bindings;

public class BasicExample
{
    static int Main(string[] args)
    {
        RecombeeClient client = new RecombeeClient("--my-database-id--", "--my-secret-token--");

        try
        {
            const int NUM = 100;
            var userIds = Enumerable.Range(0, NUM).Select(i => String.Format("user-{0}", i));
            var itemIds = Enumerable.Range(0, NUM).Select(i => String.Format("item-{0}", i));
            // Generate some random purchases of items by users
            const double PROBABILITY_PURCHASED = 0.1;
            Random r = new Random();
            var purchases = new List<Request>();

            foreach(var userId in userIds) {
                purchases.AddRange(
                    itemIds.Where(_ => r.NextDouble() < PROBABILITY_PURCHASED)
                           .Select(itemId =>
                                    new AddPurchase(userId, itemId, cascadeCreate: true) // Use cascadeCreate parameter to create
                           )                                                             // the yet non-existing users and items
                );
            }

            Console.WriteLine("Send purchases");
            client.Send(new Batch(purchases)); //Use Batch for faster processing of larger data

            // Get 5 recommendations for user 'user-25'
            RecommendationResponse recommendationResponse = client.Send(new RecommendItemsToUser("user-25", 5));
            Console.WriteLine("Recommended items:");
            foreach(Recommendation rec in recommendationResponse.Recomms) Console.WriteLine(rec.Id);

        }
        catch(ApiException e)
        {
         Console.WriteLine(e.ToString());
         // Use fallback
        }

        return 0;
    }
}

```

### Using property values

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using Recombee.ApiClient;
using Recombee.ApiClient.ApiRequests;
using Recombee.ApiClient.Bindings;

public class PropertiesExample
{
    static int Main(string[] args)
    {
        RecombeeClient client = new RecombeeClient("--my-database-id--", "--my-secret-token--");

         
        /*
        We will use computers as items in this example
        Computers have three properties
            - price (floating point number)
            - number of processor cores (integer number)
            - description (string)
        */

         try
         {
            client.Send(new ResetDatabase());
            client.Send(new AddItemProperty("price", "double"));
            client.Send(new AddItemProperty("num-cores", "int"));
            client.Send(new AddItemProperty("description", "string"));

            // Prepare requests for setting a catalog of computers
            var requests = new List<Request>();
            const int NUM = 100;
            Random r = new Random();
            var itemIds = Enumerable.Range(0, NUM).Select(i => String.Format("computer-{0}", i));
            foreach(var itemId in itemIds)
            {
                var req = new SetItemValues(
                    itemId,
                    //values:
                    new Dictionary<string, object>() {
                        {"price", 600.0 + 400*r.NextDouble()},
                        {"num-cores", 1 + r.Next(7)},
                        {"description", "Great computer"}
                    },
                    cascadeCreate: true // Use cascadeCreate for creating item
                                        // with given itemId, if it doesn't exist
                );  
                                           
                requests.Add(req);
            }
            client.Send(new Batch(requests)); // Send catalog to the recommender system

            // Generate some random purchases of items by users
            var userIds = Enumerable.Range(0, NUM).Select(i => String.Format("user-{0}", i));
            const double PROBABILITY_PURCHASED = 0.1;
            var purchases = new List<Request>();

            foreach(var userId in userIds) {
                purchases.AddRange(
                    itemIds.Where(_ => r.NextDouble() < PROBABILITY_PURCHASED)
                           .Select(itemId => 
                                    new AddPurchase(userId, itemId, cascadeCreate: true) // Use cascadeCreate parameter to create
                           )                                                             // the yet non-existing users and items                                                               
                );
            }

            client.Send(new Batch(purchases)); // Send purchases to the recommender system
        

            // Get 5 recommendations for user-42, who is currently viewing computer-6
            var recommendationResponse = client.Send(new RecommendItemsToItem("computer-6", "user-42", 5));
            Console.WriteLine("Recommended items:");
            foreach(Recommendation rec in recommendationResponse.Recomms) Console.WriteLine(rec.Id);


            // Recommend only computers that have at least 3 cores
            recommendationResponse = client.Send(new RecommendItemsToItem("computer-6", "user-42", 5,
                                            filter: " 'num-cores'>=3 "));
            Console.WriteLine("Recommended items with at least 3 processor cores:");
            foreach(Recommendation rec in recommendationResponse.Recomms) Console.WriteLine(rec.Id);

            // Recommend only items that are more expensive then currently viewed item (up-sell)
            recommendationResponse = client.Send(new RecommendItemsToItem("computer-6", "user-42", 5,
                                            filter: " 'price' > context_item[\"price\"] "));
            Console.WriteLine("Recommended up-sell items:");
            foreach(Recommendation rec in recommendationResponse.Recomms) Console.WriteLine(rec.Id);
         }
         catch(ApiException e)
         {
             Console.WriteLine(e.ToString());
             // Use fallback
         }
        return 0;
    }
}
```

## Exception handling

Various errors can occur while processing request, for example because of adding an already existing item or submitting interaction of nonexistent user without *cascadeCreate* set to true. These errors lead to throwing the *ResponseException* by the *send* method of the client. Another reason for throwing an exception is a timeout. *ApiException* is the base class of both *ResponseException* and *TimeoutException*.

We are doing our best to provide the fastest and most reliable service, but production-level applications must implement a fallback solution since errors can always happen. The fallback might be, for example, showing the most popular items from the current category, or not displaying recommendations at all.