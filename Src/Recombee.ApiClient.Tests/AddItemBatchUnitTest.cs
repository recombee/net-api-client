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
    public class AddItemBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestAddItem()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new AddItem("valid_id"),
                new AddItem("***not_valid$$$"),
                new AddItem("valid_id2"),
                new AddItem("valid_id2")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(3));
        }

        [Fact]
        public async void TestAddItemAsync()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new AddItem("valid_id"),
                new AddItem("***not_valid$$$"),
                new AddItem("valid_id2"),
                new AddItem("valid_id2")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(3));
        }
    }
}
