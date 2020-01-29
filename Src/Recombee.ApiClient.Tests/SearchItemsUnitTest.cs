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
            Request req2;
            SearchResponse resp;
            // it 'finds "hello"'
            req = new SearchItems("entity_id","hell",9);
            resp = client.Send(req);
            Assert.Equal(1, resp.Recomms.Count());
            // it 'does not find random string'
            req = new SearchItems("entity_id","sdhskldf",9);
            resp = client.Send(req);
            Assert.Equal(0, resp.Recomms.Count());
            // it 'returnProperties'
            req = new SearchItems("entity_id","hell",9,returnProperties: true);
            resp = client.Send(req);
            Assert.Equal(1, resp.Recomms.Count());
        }

        [Fact]
        public async void TestSearchItemsAsync()
        {
            SearchItems req;
            Request req2;
            SearchResponse resp;
            // it 'finds "hello"'
            req = new SearchItems("entity_id","hell",9);
            resp = await client.SendAsync(req);
            Assert.Equal(1, resp.Recomms.Count());
            // it 'does not find random string'
            req = new SearchItems("entity_id","sdhskldf",9);
            resp = await client.SendAsync(req);
            Assert.Equal(0, resp.Recomms.Count());
            // it 'returnProperties'
            req = new SearchItems("entity_id","hell",9,returnProperties: true);
            resp = await client.SendAsync(req);
            Assert.Equal(1, resp.Recomms.Count());
        }
    }
}
