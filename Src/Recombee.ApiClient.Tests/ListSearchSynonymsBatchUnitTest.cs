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
    public class ListSearchSynonymsBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListSearchSynonyms()
        {
            Object resp2;
            System.Threading.Thread.Sleep(10000);
        resp2 = client.Send(new AddSearchSynonym("sci-fi", "science fiction"));
        
            Request[] requests = new Request[] {
                new ListSearchSynonyms(),
                new ListSearchSynonyms(count: 10, offset: 1)
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((ListSearchSynonymsResponse) batchResponse[0]).Synonyms.Count());
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(0, ((ListSearchSynonymsResponse) batchResponse[1]).Synonyms.Count());
        }

        [Fact]
        public async void TestListSearchSynonymsAsync()
        {
            Object resp2;
            System.Threading.Thread.Sleep(10000);
        resp2 = await client.SendAsync(new AddSearchSynonym("sci-fi", "science fiction"));
        
            Request[] requests = new Request[] {
                new ListSearchSynonyms(),
                new ListSearchSynonyms(count: 10, offset: 1)
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((ListSearchSynonymsResponse) batchResponse[0]).Synonyms.Count());
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(0, ((ListSearchSynonymsResponse) batchResponse[1]).Synonyms.Count());
        }
    }
}
