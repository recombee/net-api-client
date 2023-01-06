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
    public class UpdateManualReqlSegmentUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestUpdateManualReqlSegment()
        {
            UpdateManualReqlSegment req;
            RecombeeBinding resp;
            Object resp2;
            // it 'updates manual ReQL segment'
            resp2 = client.Send(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
            resp2 = client.Send(new AddManualReqlSegment("seg1", "first-segment", "'str_property' != null", title: "First Segment"));
            resp = client.Send(new UpdateManualReqlSegment("seg1", "first-segment", "'str_property' == null", title: "Updated Segment"));
        }

        [Fact]
        public async void TestUpdateManualReqlSegmentAsync()
        {
            UpdateManualReqlSegment req;
            RecombeeBinding resp;
            Object resp2;
            // it 'updates manual ReQL segment'
            resp2 = await client.SendAsync(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
            resp2 = await client.SendAsync(new AddManualReqlSegment("seg1", "first-segment", "'str_property' != null", title: "First Segment"));
            resp = await client.SendAsync(new UpdateManualReqlSegment("seg1", "first-segment", "'str_property' == null", title: "Updated Segment"));
        }
    }
}
