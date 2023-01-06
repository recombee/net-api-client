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
    public class GetSegmentationBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestGetSegmentation()
        {
            Object resp2;
            resp2 = client.Send(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
        
            Request[] requests = new Request[] {
                new GetSegmentation("seg1")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal ("seg1",((Segmentation) batchResponse[0]).SegmentationId);
        }

        [Fact]
        public async void TestGetSegmentationAsync()
        {
            Object resp2;
            resp2 = await client.SendAsync(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
        
            Request[] requests = new Request[] {
                new GetSegmentation("seg1")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal ("seg1",((Segmentation) batchResponse[0]).SegmentationId);
        }
    }
}
