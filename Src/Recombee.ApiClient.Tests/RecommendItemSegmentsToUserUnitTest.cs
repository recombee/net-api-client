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
    public class RecommendItemSegmentsToUserUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestRecommendItemSegmentsToUser()
        {
            RecommendItemSegmentsToUser req;
            RecommendationResponse resp;
            Object resp2;
            // it 'rejects request to scenario which is not set up'
            try
            {
                client.Send(new RecommendItemSegmentsToUser("entity_id", 5, scenario: "scenario1", cascadeCreate: true));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestRecommendItemSegmentsToUserAsync()
        {
            RecommendItemSegmentsToUser req;
            RecommendationResponse resp;
            Object resp2;
            // it 'rejects request to scenario which is not set up'
            try
            {
                await client.SendAsync(new RecommendItemSegmentsToUser("entity_id", 5, scenario: "scenario1", cascadeCreate: true));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
        }
    }
}
