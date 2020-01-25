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
    public class ListItemPropertiesBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListItemProperties()
                {
            Request[] requests = new Request[] {
                new ListItemProperties()
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(2, ((IEnumerable<PropertyInfo>) batchResponse[0]).Count());
        }

        [Fact]
        public async void TestListItemPropertiesAsync()
                {
            Request[] requests = new Request[] {
                new ListItemProperties()
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(2, ((IEnumerable<PropertyInfo>) batchResponse[0]).Count());
        }
    }
}
