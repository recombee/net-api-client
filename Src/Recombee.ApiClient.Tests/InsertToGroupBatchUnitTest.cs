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
    public class InsertToGroupBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestInsertToGroup()
        {
            Object resp2;
            resp2 = client.Send(new AddItem("new_item"));
        
            resp2 = client.Send(new AddItem("new_item3"));
        
            Request[] requests = new Request[] {
                new InsertToGroup("entity_id", "item", "new_item"),
                new InsertToGroup("new_set", "item", "new_item2", cascadeCreate: true),
                new InsertToGroup("entity_id", "item", "new_item3"),
                new InsertToGroup("entity_id", "item", "new_item3")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(3));
        }

        [Fact]
        public async void TestInsertToGroupAsync()
        {
            Object resp2;
            resp2 = await client.SendAsync(new AddItem("new_item"));
        
            resp2 = await client.SendAsync(new AddItem("new_item3"));
        
            Request[] requests = new Request[] {
                new InsertToGroup("entity_id", "item", "new_item"),
                new InsertToGroup("new_set", "item", "new_item2", cascadeCreate: true),
                new InsertToGroup("entity_id", "item", "new_item3"),
                new InsertToGroup("entity_id", "item", "new_item3")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(3));
        }
    }
}
