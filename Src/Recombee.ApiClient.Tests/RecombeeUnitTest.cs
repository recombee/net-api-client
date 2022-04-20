using System;
using System.Collections.Generic;
using Recombee.ApiClient.ApiRequests;
using Recombee.ApiClient.Util;
using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace Recombee.ApiClient.Tests
{
    public class RecombeeUnitTest
    {
        protected RecombeeClient client;
        
        public RecombeeUnitTest()
        {
                client = new RecombeeClient("client-test", "jGGQ6ZKa8rQ1zTAyxTc0EMn55YPF7FJLUtaMLhbsGxmvwxgTwXYqmUk5xVZFw98L", region: Region.EuWest);
                client.Send(new ResetDatabase());
                while (true)
                {
                    try {
                        client.Send(new ListItems());
                    }
                    catch(ResponseException) {
                        //Waiting for DB reset
                        continue;
                    }
                    break;
                }

                Batch requests = new Batch(new Request[]{
                new AddItem("entity_id"),
                new AddUser("entity_id"),
                new AddSeries("entity_id"),
                new AddGroup("entity_id"),
                new InsertToGroup("entity_id", "item", "entity_id"),
                new InsertToSeries("entity_id", "item", "entity_id", 1),
                new AddItemProperty("int_property", "int"),
                new AddItemProperty("str_property", "string"),
                new SetItemValues("entity_id", new Dictionary<string, object>()
                    {
                        {"int_property", 42},
                        {"str_property", "hello"}
                    }),
                new AddUserProperty("int_property", "int"),
                new AddUserProperty("str_property", "string"),
                new SetUserValues("entity_id", new Dictionary<string, object>()
                    {
                        {"int_property", 42},
                        {"str_property", "hello"}
                    })
                });

                client.Send(requests);
                System.Threading.Thread.Sleep(2000);
        }

        protected DateTime ParseDateTime(string dateStr)
        {
            return DateTime.Parse(dateStr, null, System.Globalization.DateTimeStyles.RoundtripKind);
        }

        //http://stackoverflow.com/questions/249760/how-to-convert-a-unix-timestamp-to-datetime-and-vice-versa
        public static DateTime UnixTimeStampToDateTime( double unixTimeStamp )
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds( unixTimeStamp ).ToLocalTime();
            return dtDateTime;
        }
    }
}
