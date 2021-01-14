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
    public class SearchItemsBatchUnitTest: RecommendationUnitTest
    {

        [Fact]
        public  void TestSearchItems()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new SearchItems("entity_id", "hell", 9),
                new SearchItems("entity_id", "sdhskldf", 9),
                new SearchItems("entity_id", "hell", 9, returnProperties: true)
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((SearchResponse) batchResponse[0]).Recomms.Count());
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(0, ((SearchResponse) batchResponse[1]).Recomms.Count());
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(1, ((SearchResponse) batchResponse[2]).Recomms.Count());
        }

        [Fact]
        public async void TestSearchItemsAsync()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new SearchItems("entity_id", "hell", 9),
                new SearchItems("entity_id", "sdhskldf", 9),
                new SearchItems("entity_id", "hell", 9, returnProperties: true)
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((SearchResponse) batchResponse[0]).Recomms.Count());
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(0, ((SearchResponse) batchResponse[1]).Recomms.Count());
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(1, ((SearchResponse) batchResponse[2]).Recomms.Count());
        }
    }
}
