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
    public class DeleteRatingUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestDeleteRating()
        {
            DeleteRating req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail with existing entity id'
            req = new DeleteRating("user","item",timestamp: UnixTimeStampToDateTime(0));
            resp = client.Send(req);
            req = new DeleteRating("user","item");
            try
            {
                client.Send(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestDeleteRatingAsync()
        {
            DeleteRating req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail with existing entity id'
            req = new DeleteRating("user","item",timestamp: UnixTimeStampToDateTime(0));
            resp = await client.SendAsync(req);
            req = new DeleteRating("user","item");
            try
            {
                await client.SendAsync(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }
    }
}
