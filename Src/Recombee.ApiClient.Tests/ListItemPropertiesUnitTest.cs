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
    public class ListItemPropertiesUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListItemProperties()
        {
            ListItemProperties req;
            Request req2;
            IEnumerable<PropertyInfo> resp;
            // it 'lists properties'
            req = new ListItemProperties();
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(req);
            Assert.Equal(2, resp.Count());
        }

        [Fact]
        public async void TestListItemPropertiesAsync()
        {
            ListItemProperties req;
            Request req2;
            IEnumerable<PropertyInfo> resp;
            // it 'lists properties'
            req = new ListItemProperties();
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(req);
            Assert.Equal(2, resp.Count());
        }
    }
}
