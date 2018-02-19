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
    public class DeleteSeriesBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public void TestDeleteSeries()
        {
            Request[] requests = new Request[] {
                new DeleteSeries("entity_id"),
                new DeleteSeries("entity_id"),
                new DeleteSeries("$$$not_valid$$$"),
                new DeleteSeries("valid_id")
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(3));
        }
    }
}
