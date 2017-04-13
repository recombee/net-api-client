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
    public class AddRatingUnitTest: RecombeeUnitTest
    {

        [Fact]
        public void TestAddRating()
        {
            AddRating req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail with cascadeCreate'
            req = new AddRating("u_id","i_id",1,cascadeCreate: true);
            resp = client.Send(req);
            // it 'does not fail with existing item and user'
            req = new AddRating("entity_id","entity_id",0);
            resp = client.Send(req);
            // it 'fails with nonexisting item id'
            req = new AddRating("entity_id","nonex_id",-1);
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
            req = new AddRating("nonex_id","entity_id",0.5);
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
            req = new AddRating("entity_id","entity_id",0,timestamp: UnixTimeStampToDateTime(-15));
            try
            {
                client.Send(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'fails with invalid rating'
            req = new AddRating("entity_id","entity_id",-2);
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
            req = new AddRating("u_id","i_id",0.3,cascadeCreate: true,timestamp: UnixTimeStampToDateTime(5));
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
