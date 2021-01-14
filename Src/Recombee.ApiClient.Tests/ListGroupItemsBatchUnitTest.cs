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
    public class ListGroupItemsBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListGroupItems()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new ListGroupItems("entity_id")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<GroupItem>) batchResponse[0]).Count());
            Assert.Equal ("entity_id",((IEnumerable<GroupItem>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("item",((IEnumerable<GroupItem>) batchResponse[0]).ElementAt(0).ItemType);
        }

        [Fact]
        public async void TestListGroupItemsAsync()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new ListGroupItems("entity_id")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<GroupItem>) batchResponse[0]).Count());
            Assert.Equal ("entity_id",((IEnumerable<GroupItem>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("item",((IEnumerable<GroupItem>) batchResponse[0]).ElementAt(0).ItemType);
        }
    }
}
