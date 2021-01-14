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
    public class RecommendNextItemsUnitTest: RecommendationUnitTest
    {

        [Fact]
        public  void TestRecommendNextItems()
        {
            RecommendNextItems req;
            RecommendationResponse resp;
            Object resp2;
            // it 'recommends'
            resp2 = client.Send(new RecommendItemsToUser("entity_id", 3, returnProperties: true));
            resp = client.Send(new RecommendNextItems(((RecommendationResponse)resp2).RecommId, 3));
            Assert.Equal(3, resp.Recomms.Count());
            resp = client.Send(new RecommendNextItems(((RecommendationResponse)resp2).RecommId, 3));
            Assert.Equal(3, resp.Recomms.Count());
        }

        [Fact]
        public async void TestRecommendNextItemsAsync()
        {
            RecommendNextItems req;
            RecommendationResponse resp;
            Object resp2;
            // it 'recommends'
            resp2 = await client.SendAsync(new RecommendItemsToUser("entity_id", 3, returnProperties: true));
            resp = await client.SendAsync(new RecommendNextItems(((RecommendationResponse)resp2).RecommId, 3));
            Assert.Equal(3, resp.Recomms.Count());
            resp = await client.SendAsync(new RecommendNextItems(((RecommendationResponse)resp2).RecommId, 3));
            Assert.Equal(3, resp.Recomms.Count());
        }
    }
}
