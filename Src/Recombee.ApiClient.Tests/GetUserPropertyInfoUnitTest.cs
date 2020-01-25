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
            Request req2;
            PropertyInfo resp;
            // it 'does not fail with existing properties'
            req = new GetUserPropertyInfo("int_property");
            resp = client.Send(req);
            Assert.Equal ("int",resp.Type);
            req = new GetUserPropertyInfo("str_property");
            resp = client.Send(req);
            Assert.Equal ("string",resp.Type);
        }

        [Fact]
        public async void TestGetUserPropertyInfoAsync()
        {
            GetUserPropertyInfo req;
            Request req2;
            PropertyInfo resp;
            // it 'does not fail with existing properties'
            req = new GetUserPropertyInfo("int_property");
            resp = await client.SendAsync(req);
            Assert.Equal ("int",resp.Type);
            req = new GetUserPropertyInfo("str_property");
            resp = await client.SendAsync(req);
            Assert.Equal ("string",resp.Type);
        }
    }
}
