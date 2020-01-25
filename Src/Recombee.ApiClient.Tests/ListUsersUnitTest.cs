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
            Request req2;
            IEnumerable<User> resp;
            // it 'lists entities'
            req = new ListUsers();
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(req);
            Assert.Equal (new User[]{new User("entity_id")},resp);
            // it 'return properties'
            req = new ListUsers();
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(req);
            Assert.Equal(1, resp.Count());
        }

        [Fact]
        public async void TestListUsersAsync()
        {
            ListUsers req;
            Request req2;
            IEnumerable<User> resp;
            // it 'lists entities'
            req = new ListUsers();
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(req);
            Assert.Equal (new User[]{new User("entity_id")},resp);
            // it 'return properties'
            req = new ListUsers();
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(req);
            Assert.Equal(1, resp.Count());
        }
    }
}
