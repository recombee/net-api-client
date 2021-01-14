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
    public class DeleteGroupBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestDeleteGroup()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new DeleteGroup("entity_id"),
                new DeleteGroup("entity_id"),
                new DeleteGroup("***not_valid$$$"),
                new DeleteGroup("valid_id")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(3));
        }

        [Fact]
        public async void TestDeleteGroupAsync()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new DeleteGroup("entity_id"),
                new DeleteGroup("entity_id"),
                new DeleteGroup("***not_valid$$$"),
                new DeleteGroup("valid_id")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(3));
        }
    }
}
