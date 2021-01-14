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
    public class ListGroupsBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListGroups()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new ListGroups()
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal (new Group[]{new Group("entity_id")},((IEnumerable<Group>) batchResponse[0]));
        }

        [Fact]
        public async void TestListGroupsAsync()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new ListGroups()
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal (new Group[]{new Group("entity_id")},((IEnumerable<Group>) batchResponse[0]));
        }
    }
}
