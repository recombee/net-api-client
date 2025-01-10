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
    public class ListItemsUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListItems()
        {
            ListItems req;
            IEnumerable<Item> resp;
            Object resp2;
            // it 'lists entities'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListItems());
            Assert.Equal (new Item[]{new Item("entity_id")},resp);
            // it 'return properties'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListItems(returnProperties: true));
            Assert.Equal(1, resp.Count());
        }

        [Fact]
        public async void TestListItemsAsync()
        {
            ListItems req;
            IEnumerable<Item> resp;
            Object resp2;
            // it 'lists entities'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListItems());
            Assert.Equal (new Item[]{new Item("entity_id")},resp);
            // it 'return properties'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListItems(returnProperties: true));
            Assert.Equal(1, resp.Count());
        }
    }
}
