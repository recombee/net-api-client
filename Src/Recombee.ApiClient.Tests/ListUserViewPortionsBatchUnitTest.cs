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
    public class ListUserViewPortionsBatchUnitTest: InteractionsUnitTest
    {

        [Fact]
        public void TestListUserViewPortions()
        {
            Request[] requests = new Request[] {
                new ListUserViewPortions("user")
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<ViewPortion>) batchResponse[0]).Count());
            Assert.Equal ("item",((IEnumerable<ViewPortion>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("user",((IEnumerable<ViewPortion>) batchResponse[0]).ElementAt(0).UserId);
        }
    }
}
