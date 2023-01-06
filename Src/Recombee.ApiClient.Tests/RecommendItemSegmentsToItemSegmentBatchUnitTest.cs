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
    public class RecommendItemSegmentsToItemSegmentBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestRecommendItemSegmentsToItemSegment()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new RecommendItemSegmentsToItemSegment("segment_id", "entity_id", 5, scenario: "scenario1", cascadeCreate: true)
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(0));
        }

        [Fact]
        public async void TestRecommendItemSegmentsToItemSegmentAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new RecommendItemSegmentsToItemSegment("segment_id", "entity_id", 5, scenario: "scenario1", cascadeCreate: true)
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(0));
        }
    }
}
