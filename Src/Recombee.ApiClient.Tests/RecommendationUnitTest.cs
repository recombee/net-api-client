using Recombee.ApiClient.ApiRequests;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Recombee.ApiClient.Tests
{
    public class RecommendationUnitTest: RecombeeUnitTest
    {        
        public RecommendationUnitTest()
        {            
            const int NUM = 1000;
            const double PROBABILITY_PURCHASED = 0.007;

            var userIds = Enumerable.Range(0, NUM).Select(i => string.Format("user-{0}", i));
            var itemIds = Enumerable.Range(0, NUM).Select(i => string.Format("item-{0}", i));

            client.Send(new Batch(new Request[]{
                    new AddItemProperty("answer", "int"),
                    new AddItemProperty("id2", "string"),
                    new AddItemProperty("empty", "string")
            }));

            var itemRequests = itemIds.Select(itemId =>
                new SetItemValues(itemId, new Dictionary<string, object>
                {
                    {"answer", 42},
                    {"id2", itemId},
                }, cascadeCreate: true)
            );

            client.Send(new Batch(itemRequests));

            client.Send(new Batch(userIds.Select(id => new AddUser(id))));

            Random r = new Random();
            var purchases = new List<Request>();
            foreach(String userId in  userIds) {
                purchases.AddRange(
                    itemIds.Where(_ => r.NextDouble() < PROBABILITY_PURCHASED)
                        .Select(itemId => new AddPurchase(userId, itemId))
                );
            }
            client.Send(new Batch(purchases));
        }
    }
}
