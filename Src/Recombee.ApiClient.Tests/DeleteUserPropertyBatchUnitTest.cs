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
    public class DeleteUserPropertyBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public void TestDeleteUserProperty()
        {
            Request[] requests = new Request[] {
                new DeleteUserProperty("int_property"),
                new DeleteUserProperty("int_property"),
                new DeleteUserProperty("$$$not_valid$$$"),
                new DeleteUserProperty("not_existing")
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(3));
        }
    }
}
