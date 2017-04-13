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
        public void TestListUsers()
        {
            ListUsers req;
            Request req2;
            IEnumerable<User> resp;
            // it 'lists entities'
            req = new ListUsers();
            resp = client.Send(req);
            Assert.Equal (new User[]{new User("entity_id")},resp);
        }
    }
}
