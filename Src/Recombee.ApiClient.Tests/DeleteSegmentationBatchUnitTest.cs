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
    public class DeleteSegmentationBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestDeleteSegmentation()
        {
            Object resp2;
            resp2 = client.Send(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
        
            Request[] requests = new Request[] {
                new DeleteSegmentation("seg1"),
                new DeleteSegmentation("seg1")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
        }

        [Fact]
        public async void TestDeleteSegmentationAsync()
        {
            Object resp2;
            resp2 = await client.SendAsync(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
        
            Request[] requests = new Request[] {
                new DeleteSegmentation("seg1"),
                new DeleteSegmentation("seg1")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
        }
    }
}
