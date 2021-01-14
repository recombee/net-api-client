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
    public class GetUserPropertyInfoBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestGetUserPropertyInfo()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new GetUserPropertyInfo("int_property"),
                new GetUserPropertyInfo("str_property")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal ("int",((PropertyInfo) batchResponse[0]).Type);
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal ("string",((PropertyInfo) batchResponse[1]).Type);
        }

        [Fact]
        public async void TestGetUserPropertyInfoAsync()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new GetUserPropertyInfo("int_property"),
                new GetUserPropertyInfo("str_property")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal ("int",((PropertyInfo) batchResponse[0]).Type);
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal ("string",((PropertyInfo) batchResponse[1]).Type);
        }
    }
}
