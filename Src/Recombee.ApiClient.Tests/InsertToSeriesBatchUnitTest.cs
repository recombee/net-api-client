/*
 This file is auto-generated, do not edit
*/


using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Recombee.ApiClient.ApiRequests;
using Recombee.ApiClient.Bindings;

namespace Recombee.ApiClient.Tests
{
    public class InsertToSeriesBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestInsertToSeries()
        {
            Object resp2;
            resp2 = client.Send(new AddItem("new_item"));
        
            resp2 = client.Send(new AddItem("new_item3"));
        
            Request[] requests = new Request[] {
                new InsertToSeries("entity_id", "item", "new_item", 3),
                new InsertToSeries("new_set", "item", "new_item2", 1, cascadeCreate: true),
                new InsertToSeries("entity_id", "item", "new_item3", 2),
                new InsertToSeries("entity_id", "item", "new_item3", 2)
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(3));
        }

        [Fact]
        public async void TestInsertToSeriesAsync()
        {
            Object resp2;
            resp2 = await client.SendAsync(new AddItem("new_item"));
        
            resp2 = await client.SendAsync(new AddItem("new_item3"));
        
            Request[] requests = new Request[] {
                new InsertToSeries("entity_id", "item", "new_item", 3),
                new InsertToSeries("new_set", "item", "new_item2", 1, cascadeCreate: true),
                new InsertToSeries("entity_id", "item", "new_item3", 2),
                new InsertToSeries("entity_id", "item", "new_item3", 2)
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(3));
        }
    }
}
