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
    public class SearchItemSegmentsUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestSearchItemSegments()
        {
            SearchItemSegments req;
            SearchResponse resp;
            Object resp2;
            // it 'rejects request to scenario which is not set up'
            try
            {
                client.Send(new SearchItemSegments("entity_id", "query", 5, scenario: "scenario1", cascadeCreate: true));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestSearchItemSegmentsAsync()
        {
            SearchItemSegments req;
            SearchResponse resp;
            Object resp2;
            // it 'rejects request to scenario which is not set up'
            try
            {
                await client.SendAsync(new SearchItemSegments("entity_id", "query", 5, scenario: "scenario1", cascadeCreate: true));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
        }
    }
}
