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
    public class ListScenariosUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListScenarios()
        {
            ListScenarios req;
            IEnumerable<Scenario> resp;
            Object resp2;
            // it 'lists scenarios'
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(new ListScenarios());
        }

        [Fact]
        public async void TestListScenariosAsync()
        {
            ListScenarios req;
            IEnumerable<Scenario> resp;
            Object resp2;
            // it 'lists scenarios'
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(new ListScenarios());
        }
    }
}
