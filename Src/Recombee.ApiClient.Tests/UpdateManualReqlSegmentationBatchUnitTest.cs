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
    public class UpdateManualReqlSegmentationBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestUpdateManualReqlSegmentation()
        {
            Object resp2;
            resp2 = client.Send(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
        
            Request[] requests = new Request[] {
                new UpdateManualReqlSegmentation("seg1", title: "New title", description: "Updated")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }

        [Fact]
        public async void TestUpdateManualReqlSegmentationAsync()
        {
            Object resp2;
            resp2 = await client.SendAsync(new CreateManualReqlSegmentation("seg1", "items", title: "Test Segmentation", description: "For test purposes"));
        
            Request[] requests = new Request[] {
                new UpdateManualReqlSegmentation("seg1", title: "New title", description: "Updated")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }
    }
}
