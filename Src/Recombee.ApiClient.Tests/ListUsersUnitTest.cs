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
    public class ListUsersUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListUsers()
        {
            ListUsers req;
            IEnumerable<User> resp;
            Object resp2;
            // it 'lists entities'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListUsers());
            Assert.Equal (new User[]{new User("entity_id")},resp);
            // it 'return properties'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListUsers(returnProperties: true));
            Assert.Equal(1, resp.Count());
        }

        [Fact]
        public async void TestListUsersAsync()
        {
            ListUsers req;
            IEnumerable<User> resp;
            Object resp2;
            // it 'lists entities'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListUsers());
            Assert.Equal (new User[]{new User("entity_id")},resp);
            // it 'return properties'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListUsers(returnProperties: true));
            Assert.Equal(1, resp.Count());
        }
    }
}
