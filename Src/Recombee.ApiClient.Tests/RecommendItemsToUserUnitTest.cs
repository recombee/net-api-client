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
    public class RecommendItemsToUserUnitTest: RecommendationUnitTest
    {

        [Fact]
        public  void TestRecommendItemsToUser()
        {
            RecommendItemsToUser req;
            RecommendationResponse resp;
            Object resp2;
            // it 'recommends'
            resp = client.Send(new RecommendItemsToUser("entity_id", 9));
            // it 'recommends to previously nonexisting entity with cascadeCreate'
            resp = client.Send(new RecommendItemsToUser("nonexisting", 9, cascadeCreate: true));
            // it 'recommends with expert settings'
            resp = client.Send(new RecommendItemsToUser("nonexisting2", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){}));
        }

        [Fact]
        public async void TestRecommendItemsToUserAsync()
        {
            RecommendItemsToUser req;
            RecommendationResponse resp;
            Object resp2;
            // it 'recommends'
            resp = await client.SendAsync(new RecommendItemsToUser("entity_id", 9));
            // it 'recommends to previously nonexisting entity with cascadeCreate'
            resp = await client.SendAsync(new RecommendItemsToUser("nonexisting", 9, cascadeCreate: true));
            // it 'recommends with expert settings'
            resp = await client.SendAsync(new RecommendItemsToUser("nonexisting2", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){}));
        }
    }
}
