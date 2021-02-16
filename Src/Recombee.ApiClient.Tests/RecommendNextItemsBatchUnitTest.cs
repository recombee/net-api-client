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
    public class RecommendNextItemsBatchUnitTest: RecommendationUnitTest
    {

        [Fact]
        public  void TestRecommendNextItems()
        {
            Object resp2;
            resp2 = client.Send(new RecommendItemsToUser("entity_id", 3, returnProperties: true));
        
            Request[] requests = new Request[] {
                new RecommendNextItems(((RecommendationResponse)resp2).RecommId, 3),
                new RecommendNextItems(((RecommendationResponse)resp2).RecommId, 3)
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(3, ((RecommendationResponse) batchResponse[0]).Recomms.Count());
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(3, ((RecommendationResponse) batchResponse[1]).Recomms.Count());
        }

        [Fact]
        public async void TestRecommendNextItemsAsync()
        {
            Object resp2;
            resp2 = await client.SendAsync(new RecommendItemsToUser("entity_id", 3, returnProperties: true));
        
            Request[] requests = new Request[] {
                new RecommendNextItems(((RecommendationResponse)resp2).RecommId, 3),
                new RecommendNextItems(((RecommendationResponse)resp2).RecommId, 3)
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(3, ((RecommendationResponse) batchResponse[0]).Recomms.Count());
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(3, ((RecommendationResponse) batchResponse[1]).Recomms.Count());
        }
    }
}
