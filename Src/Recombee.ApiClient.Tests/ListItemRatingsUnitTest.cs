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
    public class ListItemRatingsUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestListItemRatings()
        {
            ListItemRatings req;
            Request req2;
            IEnumerable<Rating> resp;
            // it 'lists interactions'
            req = new ListItemRatings("item");
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(req);
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }

        [Fact]
        public async void TestListItemRatingsAsync()
        {
            ListItemRatings req;
            Request req2;
            IEnumerable<Rating> resp;
            // it 'lists interactions'
            req = new ListItemRatings("item");
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(req);
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }
    }
}
