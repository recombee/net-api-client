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
    public class ItemBasedRecommendationBatchUnitTest: RecommendationUnitTest
    {

        [Fact]
        public void TestItemBasedRecommendation()
        {
            Request[] requests = new Request[] {
                new ItemBasedRecommendation("entity_id",9)
            };

            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(9, ((IEnumerable<Recommendation>) batchResponse[0]).Count());
        }
    }
}
