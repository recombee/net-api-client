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
    public class DeleteMoreItemsBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestDeleteMoreItems()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new DeleteMoreItems("'int_property' == 42")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((DeleteMoreItemsResponse) batchResponse[0]).ItemIds.Count());
            Assert.Equal (1,((DeleteMoreItemsResponse) batchResponse[0]).Count);
        }

        [Fact]
        public async void TestDeleteMoreItemsAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new DeleteMoreItems("'int_property' == 42")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((DeleteMoreItemsResponse) batchResponse[0]).ItemIds.Count());
            Assert.Equal (1,((DeleteMoreItemsResponse) batchResponse[0]).Count);
        }
    }
}
