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
    public class ListGroupsUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListGroups()
        {
            ListGroups req;
            Request req2;
            IEnumerable<Group> resp;
            // it 'lists entities'
            req = new ListGroups();
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(req);
            Assert.Equal (new Group[]{new Group("entity_id")},resp);
        }

        [Fact]
        public async void TestListGroupsAsync()
        {
            ListGroups req;
            Request req2;
            IEnumerable<Group> resp;
            // it 'lists entities'
            req = new ListGroups();
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(req);
            Assert.Equal (new Group[]{new Group("entity_id")},resp);
        }
    }
}
