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
    public class CreateManualReqlSegmentationUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestCreateManualReqlSegmentation()
        {
            CreateManualReqlSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'creates manual ReQL segmentation'
            resp = client.Send(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
            try
            {
                client.Send(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestCreateManualReqlSegmentationAsync()
        {
            CreateManualReqlSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'creates manual ReQL segmentation'
            resp = await client.SendAsync(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
            try
            {
                await client.SendAsync(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }
    }
}
