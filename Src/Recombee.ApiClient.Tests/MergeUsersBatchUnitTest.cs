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
    public class MergeUsersBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestMergeUsers()
        {
            Object resp2;
            resp2 = client.Send(new AddUser("target"));
        
            Request[] requests = new Request[] {
                new MergeUsers("target", "entity_id"),
                new MergeUsers("nonex_id", "entity_id")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
        }

        [Fact]
        public async void TestMergeUsersAsync()
        {
            Object resp2;
            resp2 = await client.SendAsync(new AddUser("target"));
        
            Request[] requests = new Request[] {
                new MergeUsers("target", "entity_id"),
                new MergeUsers("nonex_id", "entity_id")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
        }
    }
}
