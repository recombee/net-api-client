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
        public void TestGetItemPropertyInfo()
        {
            GetItemPropertyInfo req;
            Request req2;
            PropertyInfo resp;
            // it 'does not fail with existing properties'
            req = new GetItemPropertyInfo("int_property");
            resp = client.Send(req);
            Assert.Equal ("int",resp.Type);
            req = new GetItemPropertyInfo("str_property");
            resp = client.Send(req);
            Assert.Equal ("string",resp.Type);
        }
    }
}
