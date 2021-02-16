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
    public class DeleteSearchSynonymBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestDeleteSearchSynonym()
        {
            Object resp2;
            resp2 = client.Send(new AddSearchSynonym("sci-fi", "science fiction"));
        
            Request[] requests = new Request[] {
                new DeleteSearchSynonym(((SearchSynonym)resp2).Id),
                new DeleteSearchSynonym("a968271b-d666-4dfb-8a30-f459e564ba7b")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
        }

        [Fact]
        public async void TestDeleteSearchSynonymAsync()
        {
            Object resp2;
            resp2 = await client.SendAsync(new AddSearchSynonym("sci-fi", "science fiction"));
        
            Request[] requests = new Request[] {
                new DeleteSearchSynonym(((SearchSynonym)resp2).Id),
                new DeleteSearchSynonym("a968271b-d666-4dfb-8a30-f459e564ba7b")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
        }
    }
}
