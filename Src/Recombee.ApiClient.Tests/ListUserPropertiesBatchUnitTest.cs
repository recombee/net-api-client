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
    public class ListUserPropertiesBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListUserProperties()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new ListUserProperties()
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(2, ((IEnumerable<PropertyInfo>) batchResponse[0]).Count());
        }

        [Fact]
        public async void TestListUserPropertiesAsync()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new ListUserProperties()
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(2, ((IEnumerable<PropertyInfo>) batchResponse[0]).Count());
        }
    }
}
