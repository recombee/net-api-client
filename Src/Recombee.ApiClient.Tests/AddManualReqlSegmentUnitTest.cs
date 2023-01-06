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
    public class AddManualReqlSegmentUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestAddManualReqlSegment()
        {
            AddManualReqlSegment req;
            RecombeeBinding resp;
            Object resp2;
            // it 'adds manual ReQL segment'
            resp2 = client.Send(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
            resp = client.Send(new AddManualReqlSegment("seg1", "first-segment", "'str_property' != null", title: "First Segment"));
        }

        [Fact]
        public async void TestAddManualReqlSegmentAsync()
        {
            AddManualReqlSegment req;
            RecombeeBinding resp;
            Object resp2;
            // it 'adds manual ReQL segment'
            resp2 = await client.SendAsync(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
            resp = await client.SendAsync(new AddManualReqlSegment("seg1", "first-segment", "'str_property' != null", title: "First Segment"));
        }
    }
}
