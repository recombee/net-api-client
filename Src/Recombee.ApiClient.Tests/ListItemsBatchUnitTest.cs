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
        public void TestListItems()
        {
            Request[] requests = new Request[] {
                new ListItems()
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal (new Item[]{new Item("entity_id")},((IEnumerable<Item>) batchResponse[0]));
        }
    }
}
