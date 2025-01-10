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
        public  void TestAddRating()
        {
            AddRating req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail with cascadeCreate'
            resp = client.Send(new AddRating("u_id", "i_id", 1, cascadeCreate: true, additionalData: new Dictionary<string, object>(){{"answer",42}}));
            // it 'does not fail with existing item and user'
            resp = client.Send(new AddRating("entity_id", "entity_id", 0));
            // it 'fails with nonexisting item id'
            try
            {
                client.Send(new AddRating("entity_id", "nonex_id", -1));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with nonexisting user id'
            try
            {
                client.Send(new AddRating("nonex_id", "entity_id", 0.5));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with invalid rating'
            try
            {
                client.Send(new AddRating("entity_id", "entity_id", -2));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'really stores interaction to the system'
            resp = client.Send(new AddRating("u_id", "i_id", 0.3, cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5)));
            try
            {
                client.Send(new AddRating("u_id", "i_id", 0.3, cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5)));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestAddRatingAsync()
        {
            AddRating req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail with cascadeCreate'
            resp = await client.SendAsync(new AddRating("u_id", "i_id", 1, cascadeCreate: true, additionalData: new Dictionary<string, object>(){{"answer",42}}));
            // it 'does not fail with existing item and user'
            resp = await client.SendAsync(new AddRating("entity_id", "entity_id", 0));
            // it 'fails with nonexisting item id'
            try
            {
                await client.SendAsync(new AddRating("entity_id", "nonex_id", -1));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with nonexisting user id'
            try
            {
                await client.SendAsync(new AddRating("nonex_id", "entity_id", 0.5));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with invalid rating'
            try
            {
                await client.SendAsync(new AddRating("entity_id", "entity_id", -2));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'really stores interaction to the system'
            resp = await client.SendAsync(new AddRating("u_id", "i_id", 0.3, cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5)));
            try
            {
                await client.SendAsync(new AddRating("u_id", "i_id", 0.3, cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5)));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }
    }
}
