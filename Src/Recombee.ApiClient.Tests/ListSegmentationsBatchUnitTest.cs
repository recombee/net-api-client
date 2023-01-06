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
    public class ListSegmentationsBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListSegmentations()
        {
            Object resp2;
            System.Threading.Thread.Sleep(10000);
        resp2 = client.Send(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
        
            Request[] requests = new Request[] {
                new ListSegmentations("items")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((ListSegmentationsResponse) batchResponse[0]).Segmentations.Count());
        }

        [Fact]
        public async void TestListSegmentationsAsync()
        {
            Object resp2;
            System.Threading.Thread.Sleep(10000);
        resp2 = await client.SendAsync(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
        
            Request[] requests = new Request[] {
                new ListSegmentations("items")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((ListSegmentationsResponse) batchResponse[0]).Segmentations.Count());
        }
    }
}
