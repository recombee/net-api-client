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
    public class ListUserBookmarksBatchUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestListUserBookmarks()
                {
            Request[] requests = new Request[] {
                new ListUserBookmarks("user")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<Bookmark>) batchResponse[0]).Count());
            Assert.Equal ("item",((IEnumerable<Bookmark>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("user",((IEnumerable<Bookmark>) batchResponse[0]).ElementAt(0).UserId);
        }

        [Fact]
        public async void TestListUserBookmarksAsync()
                {
            Request[] requests = new Request[] {
                new ListUserBookmarks("user")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<Bookmark>) batchResponse[0]).Count());
            Assert.Equal ("item",((IEnumerable<Bookmark>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("user",((IEnumerable<Bookmark>) batchResponse[0]).ElementAt(0).UserId);
        }
    }
}
