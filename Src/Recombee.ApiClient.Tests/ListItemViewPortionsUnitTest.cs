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
    public class ListItemViewPortionsUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestListItemViewPortions()
        {
            ListItemViewPortions req;
            IEnumerable<ViewPortion> resp;
            Object resp2;
            // it 'lists interactions'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListItemViewPortions("item"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }

        [Fact]
        public async void TestListItemViewPortionsAsync()
        {
            ListItemViewPortions req;
            IEnumerable<ViewPortion> resp;
            Object resp2;
            // it 'lists interactions'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListItemViewPortions("item"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }
    }
}
