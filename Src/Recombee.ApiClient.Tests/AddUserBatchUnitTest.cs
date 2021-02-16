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
    public class AddUserBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestAddUser()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new AddUser("valid_id"),
                new AddUser("***not_valid$$$"),
                new AddUser("valid_id2"),
                new AddUser("valid_id2")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(3));
        }

        [Fact]
        public async void TestAddUserAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new AddUser("valid_id"),
                new AddUser("***not_valid$$$"),
                new AddUser("valid_id2"),
                new AddUser("valid_id2")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(3));
        }
    }
}
