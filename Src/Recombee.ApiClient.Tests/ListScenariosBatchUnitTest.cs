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
    public class ListScenariosBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestListScenarios()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ListScenarios()
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }

        [Fact]
        public async void TestListScenariosAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new ListScenarios()
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
        }
    }
}
