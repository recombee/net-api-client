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
    public class ListUserDetailViewsUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestListUserDetailViews()
        {
            ListUserDetailViews req;
            IEnumerable<DetailView> resp;
            Object resp2;
            // it 'lists user interactions'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListUserDetailViews("user"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }

        [Fact]
        public async void TestListUserDetailViewsAsync()
        {
            ListUserDetailViews req;
            IEnumerable<DetailView> resp;
            Object resp2;
            // it 'lists user interactions'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListUserDetailViews("user"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }
    }
}
