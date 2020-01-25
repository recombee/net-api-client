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
            Request req2;
            RecommendationResponse resp;
            // it 'recommends'
            req = new RecommendUsersToUser("entity_id",9);
            resp = client.Send(req);
            // it 'recommends to previously nonexisting entity with cascadeCreate'
            req = new RecommendUsersToUser("nonexisting",9,cascadeCreate: true);
            resp = client.Send(req);
            // it 'recommends with expert settings'
            req = new RecommendUsersToUser("nonexisting2",9,cascadeCreate: true,expertSettings: new Dictionary<string, object>(){});
            resp = client.Send(req);
        }

        [Fact]
        public async void TestRecommendUsersToUserAsync()
        {
            RecommendUsersToUser req;
            Request req2;
            RecommendationResponse resp;
            // it 'recommends'
            req = new RecommendUsersToUser("entity_id",9);
            resp = await client.SendAsync(req);
            // it 'recommends to previously nonexisting entity with cascadeCreate'
            req = new RecommendUsersToUser("nonexisting",9,cascadeCreate: true);
            resp = await client.SendAsync(req);
            // it 'recommends with expert settings'
            req = new RecommendUsersToUser("nonexisting2",9,cascadeCreate: true,expertSettings: new Dictionary<string, object>(){});
            resp = await client.SendAsync(req);
        }
    }
}
