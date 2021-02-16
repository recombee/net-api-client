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
    public class RemoveFromGroupBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestRemoveFromGroup()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new RemoveFromGroup("entity_id", "item", "entity_id"),
                new RemoveFromGroup("entity_id", "item", "not_contained")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
        }

        [Fact]
        public async void TestRemoveFromGroupAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new RemoveFromGroup("entity_id", "item", "entity_id"),
                new RemoveFromGroup("entity_id", "item", "not_contained")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
        }
    }
}
