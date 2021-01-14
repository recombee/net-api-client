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
    public class ListSeriesItemsUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListSeriesItems()
        {
            ListSeriesItems req;
            IEnumerable<SeriesItem> resp;
            Object resp2;
            // it 'lists set items'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListSeriesItems("entity_id"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("entity_id",resp.ElementAt(0).ItemId);
            Assert.Equal ("item",resp.ElementAt(0).ItemType);
        }

        [Fact]
        public async void TestListSeriesItemsAsync()
        {
            ListSeriesItems req;
            IEnumerable<SeriesItem> resp;
            Object resp2;
            // it 'lists set items'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListSeriesItems("entity_id"));
            Assert.Equal(1, resp.Count());
            Assert.Equal ("entity_id",resp.ElementAt(0).ItemId);
            Assert.Equal ("item",resp.ElementAt(0).ItemType);
        }
    }
}
