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
    public class MergeUsersUnitTest: RecombeeUnitTest
    {

        [Fact]
        public void TestMergeUsers()
        {
            MergeUsers req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail with existing users'
            req2 = new AddUser("target");
            client.Send(req2);
            req = new MergeUsers("target","entity_id");
            resp = client.Send(req);
            // it 'fails with nonexisting user'
            req = new MergeUsers("nonex_id","entity_id");
            try
            {
                client.Send(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }
    }
}
