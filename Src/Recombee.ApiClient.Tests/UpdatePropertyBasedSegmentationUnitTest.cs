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
    public class UpdatePropertyBasedSegmentationUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestUpdatePropertyBasedSegmentation()
        {
            UpdatePropertyBasedSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'updates property based segmentation'
            resp2 = client.Send(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
            resp = client.Send(new UpdatePropertyBasedSegmentation("seg1", title: "New title", propertyName: "str_property", description: "Updated"));
        }

        [Fact]
        public async void TestUpdatePropertyBasedSegmentationAsync()
        {
            UpdatePropertyBasedSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'updates property based segmentation'
            resp2 = await client.SendAsync(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
            resp = await client.SendAsync(new UpdatePropertyBasedSegmentation("seg1", title: "New title", propertyName: "str_property", description: "Updated"));
        }
    }
}
