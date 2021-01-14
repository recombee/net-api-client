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
    public class ListUserRatingsUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestListUserRatings()
        {
            ListUserRatings req;
            IEnumerable<Rating> resp;
            Object resp2;
            // it 'lists user interactions'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListUserRatings("user"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }

        [Fact]
        public async void TestListUserRatingsAsync()
        {
            ListUserRatings req;
            IEnumerable<Rating> resp;
            Object resp2;
            // it 'lists user interactions'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListUserRatings("user"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }
    }
}
