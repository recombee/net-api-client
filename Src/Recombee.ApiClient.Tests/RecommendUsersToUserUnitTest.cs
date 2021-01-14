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
    public class RecommendUsersToUserUnitTest: RecommendationUnitTest
    {

        [Fact]
        public  void TestRecommendUsersToUser()
        {
            RecommendUsersToUser req;
            RecommendationResponse resp;
            Object resp2;
            // it 'recommends'
            resp = client.Send(new RecommendUsersToUser("entity_id", 9));
            // it 'recommends to previously nonexisting entity with cascadeCreate'
            resp = client.Send(new RecommendUsersToUser("nonexisting", 9, cascadeCreate: true));
            // it 'recommends with expert settings'
            resp = client.Send(new RecommendUsersToUser("nonexisting2", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){}));
        }

        [Fact]
        public async void TestRecommendUsersToUserAsync()
        {
            RecommendUsersToUser req;
            RecommendationResponse resp;
            Object resp2;
            // it 'recommends'
            resp = await client.SendAsync(new RecommendUsersToUser("entity_id", 9));
            // it 'recommends to previously nonexisting entity with cascadeCreate'
            resp = await client.SendAsync(new RecommendUsersToUser("nonexisting", 9, cascadeCreate: true));
            // it 'recommends with expert settings'
            resp = await client.SendAsync(new RecommendUsersToUser("nonexisting2", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){}));
        }
    }
}
