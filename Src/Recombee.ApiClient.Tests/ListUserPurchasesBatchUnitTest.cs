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
    public class ListUserPurchasesBatchUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestListUserPurchases()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ListUserPurchases("user")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<Purchase>) batchResponse[0]).Count());
            Assert.Equal ("item",((IEnumerable<Purchase>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("user",((IEnumerable<Purchase>) batchResponse[0]).ElementAt(0).UserId);
        }

        [Fact]
        public async void TestListUserPurchasesAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ListUserPurchases("user")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<Purchase>) batchResponse[0]).Count());
            Assert.Equal ("item",((IEnumerable<Purchase>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("user",((IEnumerable<Purchase>) batchResponse[0]).ElementAt(0).UserId);
        }
    }
}
