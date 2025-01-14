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
    public class AddBookmarkBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestAddBookmark()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new AddBookmark("u_id", "i_id", cascadeCreate: true, additionalData: new Dictionary<string, object>(){{"answer",42}}),
                new AddBookmark("entity_id", "entity_id"),
                new AddBookmark("entity_id", "entity_id", timestamp: ParseDateTime("2013-10-29T09:38:41.341Z")),
                new AddBookmark("entity_id", "nonex_id"),
                new AddBookmark("nonex_id", "entity_id"),
                new AddBookmark("u_id2", "i_id2", cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5)),
                new AddBookmark("u_id2", "i_id2", cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5))
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(3));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(4));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(5));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(6));
        }

        [Fact]
        public async void TestAddBookmarkAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new AddBookmark("u_id", "i_id", cascadeCreate: true, additionalData: new Dictionary<string, object>(){{"answer",42}}),
                new AddBookmark("entity_id", "entity_id"),
                new AddBookmark("entity_id", "entity_id", timestamp: ParseDateTime("2013-10-29T09:38:41.341Z")),
                new AddBookmark("entity_id", "nonex_id"),
                new AddBookmark("nonex_id", "entity_id"),
                new AddBookmark("u_id2", "i_id2", cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5)),
                new AddBookmark("u_id2", "i_id2", cascadeCreate: true, timestamp: UnixTimeStampToDateTime(5))
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(3));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(4));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(5));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(6));
        }
    }
}
