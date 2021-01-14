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
    public class AddRatingBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestAddRating()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new AddRating("u_id", "i_id", 1, cascadeCreate: true, additionalData: new Dictionary<string, object>(){{"answer",42}}),
                new AddRating("entity_id", "entity_id", 0),
                new AddRating("entity_id", "nonex_id", -1),
                new AddRating("nonex_id", "entity_id", 0.5),
                new AddRating("entity_id", "entity_id", 0, timestamp: UnixTimeStampToDateTime(-15)),
                new AddRating("entity_id", "entity_id", -2),
                new AddRating("u_id", "i_id", 0.3, cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5)),
                new AddRating("u_id", "i_id", 0.3, cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5))
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(3));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(4));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(5));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(6));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(7));
        }

        [Fact]
        public async void TestAddRatingAsync()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new AddRating("u_id", "i_id", 1, cascadeCreate: true, additionalData: new Dictionary<string, object>(){{"answer",42}}),
                new AddRating("entity_id", "entity_id", 0),
                new AddRating("entity_id", "nonex_id", -1),
                new AddRating("nonex_id", "entity_id", 0.5),
                new AddRating("entity_id", "entity_id", 0, timestamp: UnixTimeStampToDateTime(-15)),
                new AddRating("entity_id", "entity_id", -2),
                new AddRating("u_id", "i_id", 0.3, cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5)),
                new AddRating("u_id", "i_id", 0.3, cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5))
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(3));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(4));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(5));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(6));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(7));
        }
    }
}
