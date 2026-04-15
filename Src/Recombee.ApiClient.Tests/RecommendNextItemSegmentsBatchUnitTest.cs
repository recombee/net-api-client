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
    public class RecommendNextItemSegmentsBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestRecommendNextItemSegments()
        {
            Object resp2;
            try
        {
            client.Send(new RecommendNextItemSegments("invalid_recomm_id", 5));
            Assert.True(false,"No exception thrown");
        }
        catch (ResponseException ex)
        {
            Assert.Equal(400, (int)ex.StatusCode);
        }
        
            resp2 = client.Send(new RecommendItemsToUser("entity_id", 3));
        
            Request[] requests = new Request[] {
                new RecommendNextItemSegments(((RecommendationResponse)resp2).RecommId, 5)
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(0));
        }

        [Fact]
        public async void TestRecommendNextItemSegmentsAsync()
        {
            Object resp2;
            try
        {
            await client.SendAsync(new RecommendNextItemSegments("invalid_recomm_id", 5));
            Assert.True(false,"No exception thrown");
        }
        catch (ResponseException ex)
        {
            Assert.Equal(400, (int)ex.StatusCode);
        }
        
            resp2 = await client.SendAsync(new RecommendItemsToUser("entity_id", 3));
        
            Request[] requests = new Request[] {
                new RecommendNextItemSegments(((RecommendationResponse)resp2).RecommId, 5)
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(0));
        }
    }
}
