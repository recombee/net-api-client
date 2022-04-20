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
    public class UpdateMoreItemsUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestUpdateMoreItems()
        {
            UpdateMoreItems req;
            UpdateMoreItemsResponse resp;
            Object resp2;
            // it 'updates more items'
            resp = client.Send(new UpdateMoreItems("'int_property' == 42", new Dictionary<string, object>(){{"int_property",77}}));
            Assert.Equal(1, resp.ItemIds.Count());
            Assert.Equal (1,resp.Count);
        }

        [Fact]
        public async void TestUpdateMoreItemsAsync()
        {
            UpdateMoreItems req;
            UpdateMoreItemsResponse resp;
            Object resp2;
            // it 'updates more items'
            resp = await client.SendAsync(new UpdateMoreItems("'int_property' == 42", new Dictionary<string, object>(){{"int_property",77}}));
            Assert.Equal(1, resp.ItemIds.Count());
            Assert.Equal (1,resp.Count);
        }
    }
}
