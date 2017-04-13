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
    public class AddUserPropertyUnitTest: RecombeeUnitTest
    {

        [Fact]
        public void TestAddUserProperty()
        {
            AddUserProperty req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail with valid name and type'
            req = new AddUserProperty("number","int");
            resp = client.Send(req);
            req = new AddUserProperty("str","string");
            resp = client.Send(req);
            // it 'fails with invalid type'
            req = new AddUserProperty("prop","integer");
            try
            {
                client.Send(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'really stores property to the system'
            req = new AddUserProperty("number2","int");
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
