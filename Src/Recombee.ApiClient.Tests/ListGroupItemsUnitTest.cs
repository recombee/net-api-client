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
    public class ListGroupItemsUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListGroupItems()
        {
            ListGroupItems req;
            Request req2;
            IEnumerable<GroupItem> resp;
            // it 'lists set items'
            req = new ListGroupItems("entity_id");
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(req);
            Assert.Equal(1, resp.Count());
            Assert.Equal ("entity_id",resp.ElementAt(0).ItemId);
            Assert.Equal ("item",resp.ElementAt(0).ItemType);
        }

        [Fact]
        public async void TestListGroupItemsAsync()
        {
            ListGroupItems req;
            Request req2;
            IEnumerable<GroupItem> resp;
            // it 'lists set items'
            req = new ListGroupItems("entity_id");
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(req);
            Assert.Equal(1, resp.Count());
            Assert.Equal ("entity_id",resp.ElementAt(0).ItemId);
            Assert.Equal ("item",resp.ElementAt(0).ItemType);
        }
    }
}
