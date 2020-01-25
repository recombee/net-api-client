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
    public class DeleteCartAdditionBatchUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestDeleteCartAddition()
                {
            Request[] requests = new Request[] {
                new DeleteCartAddition("user","item",timestamp: UnixTimeStampToDateTime(0)),
                new DeleteCartAddition("user","item")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
        }

        [Fact]
        public async void TestDeleteCartAdditionAsync()
                {
            Request[] requests = new Request[] {
                new DeleteCartAddition("user","item",timestamp: UnixTimeStampToDateTime(0)),
                new DeleteCartAddition("user","item")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
        }
    }
}
