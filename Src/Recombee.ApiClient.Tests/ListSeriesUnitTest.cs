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
    public class ListSeriesUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListSeries()
        {
            ListSeries req;
            Request req2;
            IEnumerable<Series> resp;
            // it 'lists entities'
            req = new ListSeries();
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(req);
            Assert.Equal (new Series[]{new Series("entity_id")},resp);
        }

        [Fact]
        public async void TestListSeriesAsync()
        {
            ListSeries req;
            Request req2;
            IEnumerable<Series> resp;
            // it 'lists entities'
            req = new ListSeries();
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(req);
            Assert.Equal (new Series[]{new Series("entity_id")},resp);
        }
    }
}
