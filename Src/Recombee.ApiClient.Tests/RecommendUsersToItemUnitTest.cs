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
    public class RecommendUsersToItemUnitTest: RecommendationUnitTest
    {

        [Fact]
        public  void TestRecommendUsersToItem()
        {
            RecommendUsersToItem req;
            RecommendationResponse resp;
            Object resp2;
            // it 'recommends'
            resp = client.Send(new RecommendUsersToItem("entity_id", 9));
            // it 'recommends to previously nonexisting entity with cascadeCreate'
            resp = client.Send(new RecommendUsersToItem("nonexisting", 9, cascadeCreate: true));
            // it 'recommends with expert settings'
            resp = client.Send(new RecommendUsersToItem("nonexisting2", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){}));
        }

        [Fact]
        public async void TestRecommendUsersToItemAsync()
        {
            RecommendUsersToItem req;
            RecommendationResponse resp;
            Object resp2;
            // it 'recommends'
            resp = await client.SendAsync(new RecommendUsersToItem("entity_id", 9));
            // it 'recommends to previously nonexisting entity with cascadeCreate'
            resp = await client.SendAsync(new RecommendUsersToItem("nonexisting", 9, cascadeCreate: true));
            // it 'recommends with expert settings'
            resp = await client.SendAsync(new RecommendUsersToItem("nonexisting2", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){}));
        }
    }
}
