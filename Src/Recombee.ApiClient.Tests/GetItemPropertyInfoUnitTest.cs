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
    public class GetItemPropertyInfoUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestGetItemPropertyInfo()
        {
            GetItemPropertyInfo req;
            PropertyInfo resp;
            Object resp2;
            // it 'does not fail with existing properties'
            resp = client.Send(new GetItemPropertyInfo("int_property"));
            Assert.Equal ("int",resp.Type);
            resp = client.Send(new GetItemPropertyInfo("str_property"));
            Assert.Equal ("string",resp.Type);
        }

        [Fact]
        public async void TestGetItemPropertyInfoAsync()
        {
            GetItemPropertyInfo req;
            PropertyInfo resp;
            Object resp2;
            // it 'does not fail with existing properties'
            resp = await client.SendAsync(new GetItemPropertyInfo("int_property"));
            Assert.Equal ("int",resp.Type);
            resp = await client.SendAsync(new GetItemPropertyInfo("str_property"));
            Assert.Equal ("string",resp.Type);
        }
    }
}
