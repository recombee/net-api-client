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
    public class UpdateManualReqlSegmentBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestUpdateManualReqlSegment()
        {
            Object resp2;
            resp2 = client.Send(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
        
            resp2 = client.Send(new AddManualReqlSegment("seg1", "first-segment", "'str_property' != null", title: "First Segment"));
        
            Request[] requests = new Request[] {
                new UpdateManualReqlSegment("seg1", "first-segment", "'str_property' == null", title: "Updated Segment")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }

        [Fact]
        public async void TestUpdateManualReqlSegmentAsync()
        {
            Object resp2;
            resp2 = await client.SendAsync(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
        
            resp2 = await client.SendAsync(new AddManualReqlSegment("seg1", "first-segment", "'str_property' != null", title: "First Segment"));
        
            Request[] requests = new Request[] {
                new UpdateManualReqlSegment("seg1", "first-segment", "'str_property' == null", title: "Updated Segment")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }
    }
}
