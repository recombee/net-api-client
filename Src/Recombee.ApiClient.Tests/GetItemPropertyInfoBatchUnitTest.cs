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
    public class GetItemPropertyInfoBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public void TestGetItemPropertyInfo()
        {
            Request[] requests = new Request[] {
                new GetItemPropertyInfo("int_property"),
                new GetItemPropertyInfo("str_property")
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal ("int",((PropertyInfo) batchResponse[0]).Type);
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal ("string",((PropertyInfo) batchResponse[1]).Type);
        }
    }
}
