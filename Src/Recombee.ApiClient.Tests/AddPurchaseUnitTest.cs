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
    public class AddPurchaseUnitTest: RecombeeUnitTest
    {

        [Fact]
        public void TestAddPurchase()
        {
            AddPurchase req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail with cascadeCreate'
            req = new AddPurchase("u_id","i_id",cascadeCreate: true,additionalData: new Dictionary<string, object>(){{"answer",42}});
            resp = client.Send(req);
            // it 'does not fail with existing item and user'
            req = new AddPurchase("entity_id","entity_id");
            resp = client.Send(req);
            // it 'does not fail with valid timestamp'
            req = new AddPurchase("entity_id","entity_id",timestamp: ParseDateTime("2013-10-29T09:38:41.341Z"));
            resp = client.Send(req);
            // it 'fails with nonexisting item id'
            req = new AddPurchase("entity_id","nonex_id");
            try
            {
                client.Send(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with nonexisting user id'
            req = new AddPurchase("nonex_id","entity_id");
            try
            {
                client.Send(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with invalid time'
            req = new AddPurchase("entity_id","entity_id",timestamp: UnixTimeStampToDateTime(-15));
            try
            {
                client.Send(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'really stores interaction to the system'
            req = new AddPurchase("u_id2","i_id2",cascadeCreate: true,timestamp: UnixTimeStampToDateTime(5));
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
