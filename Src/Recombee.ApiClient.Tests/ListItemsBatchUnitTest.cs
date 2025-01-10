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
    public class ListItemsBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListItems()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ListItems(),
                new ListItems(returnProperties: true)
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal (new Item[]{new Item("entity_id")},((IEnumerable<Item>) batchResponse[0]));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(1, ((IEnumerable<Item>) batchResponse[1]).Count());
        }

        [Fact]
        public async void TestListItemsAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ListItems(),
                new ListItems(returnProperties: true)
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal (new Item[]{new Item("entity_id")},((IEnumerable<Item>) batchResponse[0]));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(1, ((IEnumerable<Item>) batchResponse[1]).Count());
        }
    }
}
