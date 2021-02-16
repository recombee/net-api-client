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
    public class AddSearchSynonymBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestAddSearchSynonym()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new AddSearchSynonym("sci-fi", "science fiction", oneWay: true),
                new AddSearchSynonym("sci-fi", "science fiction", oneWay: true)
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal ("sci-fi",((SearchSynonym) batchResponse[0]).Term);
            Assert.Equal ("science fiction",((SearchSynonym) batchResponse[0]).Synonym);
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(1));
        }

        [Fact]
        public async void TestAddSearchSynonymAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new AddSearchSynonym("sci-fi", "science fiction", oneWay: true),
                new AddSearchSynonym("sci-fi", "science fiction", oneWay: true)
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal ("sci-fi",((SearchSynonym) batchResponse[0]).Term);
            Assert.Equal ("science fiction",((SearchSynonym) batchResponse[0]).Synonym);
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(1));
        }
    }
}
