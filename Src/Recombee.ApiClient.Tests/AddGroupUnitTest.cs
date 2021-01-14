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
    public class AddGroupUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestAddGroup()
        {
            AddGroup req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail with valid entity id'
            resp = client.Send(new AddGroup("valid_id"));
            // it 'fails with invalid entity id'
            try
            {
                client.Send(new AddGroup("***not_valid$$$"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'really stores entity to the system'
            resp = client.Send(new AddGroup("valid_id2"));
            try
            {
                client.Send(new AddGroup("valid_id2"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestAddGroupAsync()
        {
            AddGroup req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail with valid entity id'
            resp = await client.SendAsync(new AddGroup("valid_id"));
            // it 'fails with invalid entity id'
            try
            {
                await client.SendAsync(new AddGroup("***not_valid$$$"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'really stores entity to the system'
            resp = await client.SendAsync(new AddGroup("valid_id2"));
            try
            {
                await client.SendAsync(new AddGroup("valid_id2"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }
    }
}
