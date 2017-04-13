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
    public class DeleteGroupUnitTest: RecombeeUnitTest
    {

        [Fact]
        public void TestDeleteGroup()
        {
            DeleteGroup req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail with existing entity id'
            req = new DeleteGroup("entity_id");
            resp = client.Send(req);
            try
            {
                client.Send(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with invalid entity id'
            req = new DeleteGroup("...not_valid...");
            try
            {
                client.Send(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'fails with non-existing entity'
            req = new DeleteGroup("valid_id");
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
