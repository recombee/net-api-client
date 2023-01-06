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
    public class CreateAutoReqlSegmentationBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestCreateAutoReqlSegmentation()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new CreateAutoReqlSegmentation("seg1", "items", "{'str_property'}", title: "Test Segmentation", description: "For test purposes"),
                new CreateAutoReqlSegmentation("seg1", "items", "{'str_property'}", title: "Test Segmentation", description: "For test purposes")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(1));
        }

        [Fact]
        public async void TestCreateAutoReqlSegmentationAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new CreateAutoReqlSegmentation("seg1", "items", "{'str_property'}", title: "Test Segmentation", description: "For test purposes"),
                new CreateAutoReqlSegmentation("seg1", "items", "{'str_property'}", title: "Test Segmentation", description: "For test purposes")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(1));
        }
    }
}
