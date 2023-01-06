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
    public class CreatePropertyBasedSegmentationUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestCreatePropertyBasedSegmentation()
        {
            CreatePropertyBasedSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'creates property based segmentation'
            resp = client.Send(new CreatePropertyBasedSegmentation("seg1", "items", "str_property", title: "Test Segmentation", description: "For test purposes"));
            try
            {
                client.Send(new CreatePropertyBasedSegmentation("seg1", "items", "str_property", title: "Test Segmentation", description: "For test purposes"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestCreatePropertyBasedSegmentationAsync()
        {
            CreatePropertyBasedSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'creates property based segmentation'
            resp = await client.SendAsync(new CreatePropertyBasedSegmentation("seg1", "items", "str_property", title: "Test Segmentation", description: "For test purposes"));
            try
            {
                await client.SendAsync(new CreatePropertyBasedSegmentation("seg1", "items", "str_property", title: "Test Segmentation", description: "For test purposes"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }
    }
}
