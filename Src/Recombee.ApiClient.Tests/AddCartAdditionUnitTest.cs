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
    public class AddCartAdditionUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestAddCartAddition()
        {
            AddCartAddition req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail with cascadeCreate'
            resp = client.Send(new AddCartAddition("u_id", "i_id", cascadeCreate: true, additionalData: new Dictionary<string, object>(){{"answer",42}}));
            // it 'does not fail with existing item and user'
            resp = client.Send(new AddCartAddition("entity_id", "entity_id"));
            // it 'does not fail with valid timestamp'
            resp = client.Send(new AddCartAddition("entity_id", "entity_id", timestamp: ParseDateTime("2013-10-29T09:38:41.341Z")));
            // it 'fails with nonexisting item id'
            try
            {
                client.Send(new AddCartAddition("entity_id", "nonex_id"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with nonexisting user id'
            try
            {
                client.Send(new AddCartAddition("nonex_id", "entity_id"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'really stores interaction to the system'
            resp = client.Send(new AddCartAddition("u_id2", "i_id2", cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5)));
            try
            {
                client.Send(new AddCartAddition("u_id2", "i_id2", cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5)));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestAddCartAdditionAsync()
        {
            AddCartAddition req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail with cascadeCreate'
            resp = await client.SendAsync(new AddCartAddition("u_id", "i_id", cascadeCreate: true, additionalData: new Dictionary<string, object>(){{"answer",42}}));
            // it 'does not fail with existing item and user'
            resp = await client.SendAsync(new AddCartAddition("entity_id", "entity_id"));
            // it 'does not fail with valid timestamp'
            resp = await client.SendAsync(new AddCartAddition("entity_id", "entity_id", timestamp: ParseDateTime("2013-10-29T09:38:41.341Z")));
            // it 'fails with nonexisting item id'
            try
            {
                await client.SendAsync(new AddCartAddition("entity_id", "nonex_id"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with nonexisting user id'
            try
            {
                await client.SendAsync(new AddCartAddition("nonex_id", "entity_id"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'really stores interaction to the system'
            resp = await client.SendAsync(new AddCartAddition("u_id2", "i_id2", cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5)));
            try
            {
                await client.SendAsync(new AddCartAddition("u_id2", "i_id2", cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5)));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }
    }
}
