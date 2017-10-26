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
    public class RecommendUsersToUserBatchUnitTest: RecommendationUnitTest
    {

        [Fact]
        public void TestRecommendUsersToUser()
        {
            Request[] requests = new Request[] {
                new RecommendUsersToUser("entity_id",9),
                new RecommendUsersToUser("nonexisting",9,cascadeCreate: true),
                new RecommendUsersToUser("nonexisting2",9,cascadeCreate: true,expertSettings: new Dictionary<string, object>(){})
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
        }
    }
}
