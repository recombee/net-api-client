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
    public class SetViewPortionUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestSetViewPortion()
        {
            SetViewPortion req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail with cascadeCreate'
            resp = client.Send(new SetViewPortion("u_id", "i_id", 1, cascadeCreate: true, additionalData: new Dictionary<string, object>(){{"answer",42}}));
            // it 'does not fail with existing item and user'
            resp = client.Send(new SetViewPortion("entity_id", "entity_id", 0));
            // it 'fails with nonexisting item id'
            try
            {
                client.Send(new SetViewPortion("entity_id", "nonex_id", 1));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with nonexisting user id'
            try
            {
                client.Send(new SetViewPortion("nonex_id", "entity_id", 0.5));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with invalid portion'
            try
            {
                client.Send(new SetViewPortion("entity_id", "entity_id", -2));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'fails with invalid sessionId'
            try
            {
                client.Send(new SetViewPortion("entity_id", "entity_id", 0.7, sessionId: "a****"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestSetViewPortionAsync()
        {
            SetViewPortion req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail with cascadeCreate'
            resp = await client.SendAsync(new SetViewPortion("u_id", "i_id", 1, cascadeCreate: true, additionalData: new Dictionary<string, object>(){{"answer",42}}));
            // it 'does not fail with existing item and user'
            resp = await client.SendAsync(new SetViewPortion("entity_id", "entity_id", 0));
            // it 'fails with nonexisting item id'
            try
            {
                await client.SendAsync(new SetViewPortion("entity_id", "nonex_id", 1));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with nonexisting user id'
            try
            {
                await client.SendAsync(new SetViewPortion("nonex_id", "entity_id", 0.5));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with invalid portion'
            try
            {
                await client.SendAsync(new SetViewPortion("entity_id", "entity_id", -2));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'fails with invalid sessionId'
            try
            {
                await client.SendAsync(new SetViewPortion("entity_id", "entity_id", 0.7, sessionId: "a****"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
        }
    }
}
