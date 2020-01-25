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
    public class AddDetailViewUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestAddDetailView()
        {
            AddDetailView req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail with cascadeCreate'
            req = new AddDetailView("u_id","i_id",cascadeCreate: true,additionalData: new Dictionary<string, object>(){{"answer",42}});
            resp = client.Send(req);
            // it 'does not fail with existing item and user'
            req = new AddDetailView("entity_id","entity_id");
            resp = client.Send(req);
            // it 'does not fail with valid timestamp'
            req = new AddDetailView("entity_id","entity_id",timestamp: ParseDateTime("2013-10-29T09:38:41.341Z"));
            resp = client.Send(req);
            // it 'fails with nonexisting item id'
            req = new AddDetailView("entity_id","nonex_id");
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
            req = new AddDetailView("nonex_id","entity_id");
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
            req = new AddDetailView("entity_id","entity_id",timestamp: UnixTimeStampToDateTime(-15));
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
            req = new AddDetailView("u_id2","i_id2",cascadeCreate: true,timestamp: UnixTimeStampToDateTime(5));
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

        [Fact]
        public async void TestAddDetailViewAsync()
        {
            AddDetailView req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail with cascadeCreate'
            req = new AddDetailView("u_id","i_id",cascadeCreate: true,additionalData: new Dictionary<string, object>(){{"answer",42}});
            resp = await client.SendAsync(req);
            // it 'does not fail with existing item and user'
            req = new AddDetailView("entity_id","entity_id");
            resp = await client.SendAsync(req);
            // it 'does not fail with valid timestamp'
            req = new AddDetailView("entity_id","entity_id",timestamp: ParseDateTime("2013-10-29T09:38:41.341Z"));
            resp = await client.SendAsync(req);
            // it 'fails with nonexisting item id'
            req = new AddDetailView("entity_id","nonex_id");
            try
            {
                await client.SendAsync(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with nonexisting user id'
            req = new AddDetailView("nonex_id","entity_id");
            try
            {
                await client.SendAsync(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with invalid time'
            req = new AddDetailView("entity_id","entity_id",timestamp: UnixTimeStampToDateTime(-15));
            try
            {
                await client.SendAsync(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'really stores interaction to the system'
            req = new AddDetailView("u_id2","i_id2",cascadeCreate: true,timestamp: UnixTimeStampToDateTime(5));
            resp = await client.SendAsync(req);
            try
            {
                await client.SendAsync(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }
    }
}
