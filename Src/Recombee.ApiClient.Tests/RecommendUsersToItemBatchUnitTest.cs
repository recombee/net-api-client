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
    public class RecommendUsersToItemBatchUnitTest: RecommendationUnitTest
    {

        [Fact]
        public  void TestRecommendUsersToItem()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new RecommendUsersToItem("entity_id", 9),
                new RecommendUsersToItem("nonexisting", 9, cascadeCreate: true),
                new RecommendUsersToItem("nonexisting2", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){}),
                new RecommendUsersToItem("nonexisting2", 9, cascadeCreate: true, reqlExpressions: new Dictionary<string, string>(){{"boolean","true"}, {"number","if ('answer' > 0) then 1 else 2"}, {"string","\"test\""}})
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(3));
        }

        [Fact]
        public async void TestRecommendUsersToItemAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new RecommendUsersToItem("entity_id", 9),
                new RecommendUsersToItem("nonexisting", 9, cascadeCreate: true),
                new RecommendUsersToItem("nonexisting2", 9, cascadeCreate: true, expertSettings: new Dictionary<string, object>(){}),
                new RecommendUsersToItem("nonexisting2", 9, cascadeCreate: true, reqlExpressions: new Dictionary<string, string>(){{"boolean","true"}, {"number","if ('answer' > 0) then 1 else 2"}, {"string","\"test\""}})
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(3));
        }
    }
}
