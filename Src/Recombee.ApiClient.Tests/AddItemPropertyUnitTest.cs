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
    public class AddItemPropertyUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestAddItemProperty()
        {
            AddItemProperty req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail with valid name and type'
            resp = client.Send(new AddItemProperty("number", "int"));
            resp = client.Send(new AddItemProperty("str", "string"));
            // it 'fails with invalid type'
            try
            {
                client.Send(new AddItemProperty("prop", "integer"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'really stores property to the system'
            resp = client.Send(new AddItemProperty("number2", "int"));
            try
            {
                client.Send(new AddItemProperty("number2", "int"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestAddItemPropertyAsync()
        {
            AddItemProperty req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail with valid name and type'
            resp = await client.SendAsync(new AddItemProperty("number", "int"));
            resp = await client.SendAsync(new AddItemProperty("str", "string"));
            // it 'fails with invalid type'
            try
            {
                await client.SendAsync(new AddItemProperty("prop", "integer"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(400, (int)ex.StatusCode);
            }
            // it 'really stores property to the system'
            resp = await client.SendAsync(new AddItemProperty("number2", "int"));
            try
            {
                await client.SendAsync(new AddItemProperty("number2", "int"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }
    }
}
