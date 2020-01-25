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
    public class ListSeriesItemsBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListSeriesItems()
                {
            Request[] requests = new Request[] {
                new ListSeriesItems("entity_id")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<SeriesItem>) batchResponse[0]).Count());
            Assert.Equal ("entity_id",((IEnumerable<SeriesItem>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("item",((IEnumerable<SeriesItem>) batchResponse[0]).ElementAt(0).ItemType);
        }

        [Fact]
        public async void TestListSeriesItemsAsync()
                {
            Request[] requests = new Request[] {
                new ListSeriesItems("entity_id")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<SeriesItem>) batchResponse[0]).Count());
            Assert.Equal ("entity_id",((IEnumerable<SeriesItem>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("item",((IEnumerable<SeriesItem>) batchResponse[0]).ElementAt(0).ItemType);
        }
    }
}
