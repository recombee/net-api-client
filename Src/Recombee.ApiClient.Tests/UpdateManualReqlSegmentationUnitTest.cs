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
    public class UpdateManualReqlSegmentationUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestUpdateManualReqlSegmentation()
        {
            UpdateManualReqlSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'updates manual ReQL segmentation'
            resp2 = client.Send(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
            resp = client.Send(new UpdateManualReqlSegmentation("seg1", title: "New title", description: "Updated"));
        }

        [Fact]
        public async void TestUpdateManualReqlSegmentationAsync()
        {
            UpdateManualReqlSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'updates manual ReQL segmentation'
            resp2 = await client.SendAsync(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
            resp = await client.SendAsync(new UpdateManualReqlSegmentation("seg1", title: "New title", description: "Updated"));
        }
    }
}
