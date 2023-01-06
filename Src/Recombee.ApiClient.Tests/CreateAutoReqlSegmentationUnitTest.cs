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
    public class CreateAutoReqlSegmentationUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestCreateAutoReqlSegmentation()
        {
            CreateAutoReqlSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'creates auto ReQL segmentation'
            resp = client.Send(new CreateAutoReqlSegmentation("seg1", "items", "{'str_property'}", title: "Test Segmentation", description: "For test purposes"));
            try
            {
                client.Send(new CreateAutoReqlSegmentation("seg1", "items", "{'str_property'}", title: "Test Segmentation", description: "For test purposes"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestCreateAutoReqlSegmentationAsync()
        {
            CreateAutoReqlSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'creates auto ReQL segmentation'
            resp = await client.SendAsync(new CreateAutoReqlSegmentation("seg1", "items", "{'str_property'}", title: "Test Segmentation", description: "For test purposes"));
            try
            {
                await client.SendAsync(new CreateAutoReqlSegmentation("seg1", "items", "{'str_property'}", title: "Test Segmentation", description: "For test purposes"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }
    }
}
