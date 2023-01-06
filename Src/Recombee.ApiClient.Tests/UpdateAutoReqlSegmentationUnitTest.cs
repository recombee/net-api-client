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
    public class UpdateAutoReqlSegmentationUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestUpdateAutoReqlSegmentation()
        {
            UpdateAutoReqlSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'updates auto ReQL segmentation'
            resp2 = client.Send(new CreateAutoReqlSegmentation("seg1", "items", "{'str_property'}", title: "Test Segmentation", description: "For test purposes"));
            resp = client.Send(new UpdateAutoReqlSegmentation("seg1", title: "New title", expression: "{'str_property' + 'str_property'}", description: "Updated"));
        }

        [Fact]
        public async void TestUpdateAutoReqlSegmentationAsync()
        {
            UpdateAutoReqlSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'updates auto ReQL segmentation'
            resp2 = await client.SendAsync(new CreateAutoReqlSegmentation("seg1", "items", "{'str_property'}", title: "Test Segmentation", description: "For test purposes"));
            resp = await client.SendAsync(new UpdateAutoReqlSegmentation("seg1", title: "New title", expression: "{'str_property' + 'str_property'}", description: "Updated"));
        }
    }
}
