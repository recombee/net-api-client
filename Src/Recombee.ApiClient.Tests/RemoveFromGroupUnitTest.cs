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
    public class RemoveFromGroupUnitTest: RecombeeUnitTest
    {

        [Fact]
        public void TestRemoveFromGroup()
        {
            RemoveFromGroup req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail when removing item that is contained in the set'
            req = new RemoveFromGroup("entity_id","item","entity_id");
            resp = client.Send(req);
            // it 'fails when removing item that is not contained in the set'
            req = new RemoveFromGroup("entity_id","item","not_contained");
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
