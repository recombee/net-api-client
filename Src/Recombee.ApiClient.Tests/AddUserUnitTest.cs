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
    public class AddUserUnitTest: RecombeeUnitTest
    {

        [Fact]
        public void TestAddUser()
        {
            AddUser req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail with valid entity id'
            req = new AddUser("valid_id");
            resp = client.Send(req);
            // it 'fails with invalid entity id'
            req = new AddUser("$$$not_valid$$$");
            try
            {
                client.Send(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'really stores entity to the system'
            req = new AddUser("valid_id2");
            resp = client.Send(req);
            try
            {
                client.Send(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }
    }
}
