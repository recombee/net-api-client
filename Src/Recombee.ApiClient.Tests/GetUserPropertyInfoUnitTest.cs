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
    public class GetUserPropertyInfoUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestGetUserPropertyInfo()
        {
            GetUserPropertyInfo req;
            PropertyInfo resp;
            Object resp2;
            // it 'does not fail with existing properties'
            resp = client.Send(new GetUserPropertyInfo("int_property"));
            Assert.Equal ("int",resp.Type);
            resp = client.Send(new GetUserPropertyInfo("str_property"));
            Assert.Equal ("string",resp.Type);
        }

        [Fact]
        public async void TestGetUserPropertyInfoAsync()
        {
            GetUserPropertyInfo req;
            PropertyInfo resp;
            Object resp2;
            // it 'does not fail with existing properties'
            resp = await client.SendAsync(new GetUserPropertyInfo("int_property"));
            Assert.Equal ("int",resp.Type);
            resp = await client.SendAsync(new GetUserPropertyInfo("str_property"));
            Assert.Equal ("string",resp.Type);
        }
    }
}
