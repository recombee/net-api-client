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
    public class RecommendNextItemSegmentsUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestRecommendNextItemSegments()
        {
            RecommendNextItemSegments req;
            RecommendationResponse resp;
            Object resp2;
            // it 'rejects request with invalid recommId'
            try
            {
                client.Send(new RecommendNextItemSegments("invalid_recomm_id", 5));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'rejects request to recommId which does not return item-segments'
            resp2 = client.Send(new RecommendItemsToUser("entity_id", 3));
            try
            {
                client.Send(new RecommendNextItemSegments(((RecommendationResponse)resp2).RecommId, 5));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestRecommendNextItemSegmentsAsync()
        {
            RecommendNextItemSegments req;
            RecommendationResponse resp;
            Object resp2;
            // it 'rejects request with invalid recommId'
            try
            {
                await client.SendAsync(new RecommendNextItemSegments("invalid_recomm_id", 5));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'rejects request to recommId which does not return item-segments'
            resp2 = await client.SendAsync(new RecommendItemsToUser("entity_id", 3));
            try
            {
                await client.SendAsync(new RecommendNextItemSegments(((RecommendationResponse)resp2).RecommId, 5));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
        }
    }
}
