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
    public class RecommendItemsToItemSegmentUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestRecommendItemsToItemSegment()
        {
            RecommendItemsToItemSegment req;
            RecommendationResponse resp;
            Object resp2;
            // it 'rejects request to scenario which is not set up'
            try
            {
                client.Send(new RecommendItemsToItemSegment("segment_id", "entity_id", 5, scenario: "scenario1", cascadeCreate: true));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestRecommendItemsToItemSegmentAsync()
        {
            RecommendItemsToItemSegment req;
            RecommendationResponse resp;
            Object resp2;
            // it 'rejects request to scenario which is not set up'
            try
            {
                await client.SendAsync(new RecommendItemsToItemSegment("segment_id", "entity_id", 5, scenario: "scenario1", cascadeCreate: true));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
        }
    }
}
