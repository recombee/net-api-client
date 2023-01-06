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
    public class UpdateAutoReqlSegmentationBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestUpdateAutoReqlSegmentation()
        {
            Object resp2;
            resp2 = client.Send(new CreateAutoReqlSegmentation("seg1", "items", "{'str_property'}", title: "Test Segmentation", description: "For test purposes"));
        
            Request[] requests = new Request[] {
                new UpdateAutoReqlSegmentation("seg1", title: "New title", expression: "{'str_property' + 'str_property'}", description: "Updated")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }

        [Fact]
        public async void TestUpdateAutoReqlSegmentationAsync()
        {
            Object resp2;
            resp2 = await client.SendAsync(new CreateAutoReqlSegmentation("seg1", "items", "{'str_property'}", title: "Test Segmentation", description: "For test purposes"));
        
            Request[] requests = new Request[] {
                new UpdateAutoReqlSegmentation("seg1", title: "New title", expression: "{'str_property' + 'str_property'}", description: "Updated")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }
    }
}
