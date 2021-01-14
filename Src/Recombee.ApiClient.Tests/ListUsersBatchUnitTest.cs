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
    public class ListUsersBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListUsers()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new ListUsers(),
                new ListUsers()
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal (new User[]{new User("entity_id")},((IEnumerable<User>) batchResponse[0]));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(1, ((IEnumerable<User>) batchResponse[1]).Count());
        }

        [Fact]
        public async void TestListUsersAsync()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new ListUsers(),
                new ListUsers()
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal (new User[]{new User("entity_id")},((IEnumerable<User>) batchResponse[0]));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(1, ((IEnumerable<User>) batchResponse[1]).Count());
        }
    }
}
