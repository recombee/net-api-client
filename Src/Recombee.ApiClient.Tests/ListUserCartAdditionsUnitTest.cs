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
    public class ListUserCartAdditionsUnitTest: InteractionsUnitTest
    {

        [Fact]
        public void TestListUserCartAdditions()
        {
            ListUserCartAdditions req;
            Request req2;
            IEnumerable<CartAddition> resp;
            // it 'lists user interactions'
            req = new ListUserCartAdditions("user");
            resp = client.Send(req);
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }
    }
}
