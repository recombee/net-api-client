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
    public class SearchItemsUnitTest: RecommendationUnitTest
    {

        [Fact]
        public  void TestSearchItems()
        {
            SearchItems req;
            SearchResponse resp;
            Object resp2;
            // it 'finds "hello"'
            resp = client.Send(new SearchItems("entity_id", "hell", 9));
            Assert.Equal(1, resp.Recomms.Count());
            // it 'does not find random string'
            resp = client.Send(new SearchItems("entity_id", "sdhskldf", 9));
            Assert.Equal(0, resp.Recomms.Count());
            // it 'returnProperties'
            resp = client.Send(new SearchItems("entity_id", "hell", 9, returnProperties: true));
            Assert.Equal(1, resp.Recomms.Count());
        }

        [Fact]
        public async void TestSearchItemsAsync()
        {
            SearchItems req;
            SearchResponse resp;
            Object resp2;
            // it 'finds "hello"'
            resp = await client.SendAsync(new SearchItems("entity_id", "hell", 9));
            Assert.Equal(1, resp.Recomms.Count());
            // it 'does not find random string'
            resp = await client.SendAsync(new SearchItems("entity_id", "sdhskldf", 9));
            Assert.Equal(0, resp.Recomms.Count());
            // it 'returnProperties'
            resp = await client.SendAsync(new SearchItems("entity_id", "hell", 9, returnProperties: true));
            Assert.Equal(1, resp.Recomms.Count());
        }
    }
}
