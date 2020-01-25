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
    public class ListUserPropertiesUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListUserProperties()
        {
            ListUserProperties req;
            Request req2;
            IEnumerable<PropertyInfo> resp;
            // it 'lists properties'
            req = new ListUserProperties();
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(req);
            Assert.Equal(2, resp.Count());
        }

        [Fact]
        public async void TestListUserPropertiesAsync()
        {
            ListUserProperties req;
            Request req2;
            IEnumerable<PropertyInfo> resp;
            // it 'lists properties'
            req = new ListUserProperties();
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(req);
            Assert.Equal(2, resp.Count());
        }
    }
}
