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
    public class GetSegmentationUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestGetSegmentation()
        {
            GetSegmentation req;
            Segmentation resp;
            Object resp2;
            // it 'gets existing segmentation'
            resp2 = client.Send(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
            resp = client.Send(new GetSegmentation("seg1"));
            Assert.Equal ("seg1",resp.SegmentationId);
        }

        [Fact]
        public async void TestGetSegmentationAsync()
        {
            GetSegmentation req;
            Segmentation resp;
            Object resp2;
            // it 'gets existing segmentation'
            resp2 = await client.SendAsync(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
            resp = await client.SendAsync(new GetSegmentation("seg1"));
            Assert.Equal ("seg1",resp.SegmentationId);
        }
    }
}
