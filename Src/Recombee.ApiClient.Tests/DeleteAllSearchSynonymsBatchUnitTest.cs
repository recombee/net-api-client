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
    public class DeleteAllSearchSynonymsBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestDeleteAllSearchSynonyms()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new DeleteAllSearchSynonyms()
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }

        [Fact]
        public async void TestDeleteAllSearchSynonymsAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new DeleteAllSearchSynonyms()
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }
    }
}
