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
    public class ListItemPurchasesUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestListItemPurchases()
        {
            ListItemPurchases req;
            IEnumerable<Purchase> resp;
            Object resp2;
            // it 'lists interactions'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListItemPurchases("item"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }

        [Fact]
        public async void TestListItemPurchasesAsync()
        {
            ListItemPurchases req;
            IEnumerable<Purchase> resp;
            Object resp2;
            // it 'lists interactions'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListItemPurchases("item"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }
    }
}
