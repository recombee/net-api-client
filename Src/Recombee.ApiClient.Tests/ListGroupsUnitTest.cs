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
            IEnumerable<Group> resp;
            Object resp2;
            // it 'lists entities'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListGroups());
            Assert.Equal (new Group[]{new Group("entity_id")},resp);
        }

        [Fact]
        public async void TestListGroupsAsync()
        {
            ListGroups req;
            IEnumerable<Group> resp;
            Object resp2;
            // it 'lists entities'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListGroups());
            Assert.Equal (new Group[]{new Group("entity_id")},resp);
        }
    }
}
