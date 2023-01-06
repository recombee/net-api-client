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
    public class DeleteSegmentationUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestDeleteSegmentation()
        {
            DeleteSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'deletes segmentation'
            resp2 = client.Send(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
            resp = client.Send(new DeleteSegmentation("seg1"));
            try
            {
                client.Send(new DeleteSegmentation("seg1"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestDeleteSegmentationAsync()
        {
            DeleteSegmentation req;
            RecombeeBinding resp;
            Object resp2;
            // it 'deletes segmentation'
            resp2 = await client.SendAsync(new CreatePropertyBasedSegmentation("seg1", "items", "str_property"));
            resp = await client.SendAsync(new DeleteSegmentation("seg1"));
            try
            {
                await client.SendAsync(new DeleteSegmentation("seg1"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }
    }
}
