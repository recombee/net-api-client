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
    public class DeleteUserPropertyUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestDeleteUserProperty()
        {
            DeleteUserProperty req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail with existing property'
            resp = client.Send(new DeleteUserProperty("int_property"));
            try
            {
                client.Send(new DeleteUserProperty("int_property"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with invalid property'
            try
            {
                client.Send(new DeleteUserProperty("***not_valid$$$"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'fails with non-existing property'
            try
            {
                client.Send(new DeleteUserProperty("not_existing"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestDeleteUserPropertyAsync()
        {
            DeleteUserProperty req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail with existing property'
            resp = await client.SendAsync(new DeleteUserProperty("int_property"));
            try
            {
                await client.SendAsync(new DeleteUserProperty("int_property"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'fails with invalid property'
            try
            {
                await client.SendAsync(new DeleteUserProperty("***not_valid$$$"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'fails with non-existing property'
            try
            {
                await client.SendAsync(new DeleteUserProperty("not_existing"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }
    }
}
