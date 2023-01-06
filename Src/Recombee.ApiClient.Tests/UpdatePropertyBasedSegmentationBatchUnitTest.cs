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
    public class UpdatePropertyBasedSegmentationBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestUpdatePropertyBasedSegmentation()
        {
            Object resp2;
            resp2 = client.Send(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
        
            Request[] requests = new Request[] {
                new UpdatePropertyBasedSegmentation("seg1", title: "New title", propertyName: "str_property", description: "Updated")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }

        [Fact]
        public async void TestUpdatePropertyBasedSegmentationAsync()
        {
            Object resp2;
            resp2 = await client.SendAsync(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
        
            Request[] requests = new Request[] {
                new UpdatePropertyBasedSegmentation("seg1", title: "New title", propertyName: "str_property", description: "Updated")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }
    }
}
