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
    public class ListSegmentationsUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListSegmentations()
        {
            ListSegmentations req;
            ListSegmentationsResponse resp;
            Object resp2;
            // it 'lists existing segmentations'
            System.Threading.Thread.Sleep(10000);
            resp2 = client.Send(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListSegmentations("items"));
            Assert.Equal(1, resp.Segmentations.Count());
        }

        [Fact]
        public async void TestListSegmentationsAsync()
        {
            ListSegmentations req;
            ListSegmentationsResponse resp;
            Object resp2;
            // it 'lists existing segmentations'
            System.Threading.Thread.Sleep(10000);
            resp2 = await client.SendAsync(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListSegmentations("items"));
            Assert.Equal(1, resp.Segmentations.Count());
        }
    }
}
