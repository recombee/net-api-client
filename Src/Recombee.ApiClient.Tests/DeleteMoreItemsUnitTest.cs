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
    public class DeleteMoreItemsUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestDeleteMoreItems()
        {
            DeleteMoreItems req;
            DeleteMoreItemsResponse resp;
            Object resp2;
            // it 'deletes more items'
            resp = client.Send(new DeleteMoreItems("'int_property' == 42"));
            Assert.Equal(1, resp.ItemIds.Count());
            Assert.Equal (1,resp.Count);
        }

        [Fact]
        public async void TestDeleteMoreItemsAsync()
        {
            DeleteMoreItems req;
            DeleteMoreItemsResponse resp;
            Object resp2;
            // it 'deletes more items'
            resp = await client.SendAsync(new DeleteMoreItems("'int_property' == 42"));
            Assert.Equal(1, resp.ItemIds.Count());
            Assert.Equal (1,resp.Count);
        }
    }
}
