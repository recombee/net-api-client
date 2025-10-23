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
    public class CompositeRecommendationUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestCompositeRecommendation()
        {
            CompositeRecommendation req;
            CompositeRecommendationResponse resp;
            Object resp2;
            // it 'rejects request to scenario which is not set up'
            try
            {
                client.Send(new CompositeRecommendation("scenario_id", 5, cascadeCreate: true));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestCompositeRecommendationAsync()
        {
            CompositeRecommendation req;
            CompositeRecommendationResponse resp;
            Object resp2;
            // it 'rejects request to scenario which is not set up'
            try
            {
                await client.SendAsync(new CompositeRecommendation("scenario_id", 5, cascadeCreate: true));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
        }
    }
}
