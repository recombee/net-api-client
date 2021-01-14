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
    public class RecommendItemsToItemUnitTest: RecommendationUnitTest
    {

        [Fact]
        public  void TestRecommendItemsToItem()
        {
            RecommendItemsToItem req;
            RecommendationResponse resp;
            Object resp2;
            // it 'recommends'
            resp = client.Send(new RecommendItemsToItem("entity_id", "entity_id", 9));
            // it 'recommends to previously nonexisting entity with cascadeCreate'
            resp = client.Send(new RecommendItemsToItem("nonexisting", "entity_id", 9, cascadeCreate: true));
            // it 'recommends with expert settings'
            resp = client.Send(new RecommendItemsToItem("nonexisting2", "entity_id", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){}));
        }

        [Fact]
        public async void TestRecommendItemsToItemAsync()
        {
            RecommendItemsToItem req;
            RecommendationResponse resp;
            Object resp2;
            // it 'recommends'
            resp = await client.SendAsync(new RecommendItemsToItem("entity_id", "entity_id", 9));
            // it 'recommends to previously nonexisting entity with cascadeCreate'
            resp = await client.SendAsync(new RecommendItemsToItem("nonexisting", "entity_id", 9, cascadeCreate: true));
            // it 'recommends with expert settings'
            resp = await client.SendAsync(new RecommendItemsToItem("nonexisting2", "entity_id", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){}));
        }
    }
}
