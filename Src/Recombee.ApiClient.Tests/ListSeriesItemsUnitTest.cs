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
        public void TestListSeriesItems()
        {
            ListSeriesItems req;
            Request req2;
            IEnumerable<SeriesItem> resp;
            // it 'lists set items'
            req = new ListSeriesItems("entity_id");
            resp = client.Send(req);
            Assert.Equal(1, resp.Count());
            Assert.Equal ("entity_id",resp.ElementAt(0).ItemId);
            Assert.Equal ("item",resp.ElementAt(0).ItemType);
        }
    }
}
