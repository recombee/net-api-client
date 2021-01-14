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
    public class ListItemDetailViewsUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestListItemDetailViews()
        {
            ListItemDetailViews req;
            IEnumerable<DetailView> resp;
            Object resp2;
            // it 'lists interactions'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListItemDetailViews("item"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }

        [Fact]
        public async void TestListItemDetailViewsAsync()
        {
            ListItemDetailViews req;
            IEnumerable<DetailView> resp;
            Object resp2;
            // it 'lists interactions'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListItemDetailViews("item"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }
    }
}
