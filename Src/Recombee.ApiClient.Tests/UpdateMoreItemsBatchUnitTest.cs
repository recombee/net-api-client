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
    public class UpdateMoreItemsBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestUpdateMoreItems()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new UpdateMoreItems("'int_property' == 42", new Dictionary<string, object>(){{"int_property",77}})
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((UpdateMoreItemsResponse) batchResponse[0]).ItemIds.Count());
            Assert.Equal (1,((UpdateMoreItemsResponse) batchResponse[0]).Count);
        }

        [Fact]
        public async void TestUpdateMoreItemsAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new UpdateMoreItems("'int_property' == 42", new Dictionary<string, object>(){{"int_property",77}})
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((UpdateMoreItemsResponse) batchResponse[0]).ItemIds.Count());
            Assert.Equal (1,((UpdateMoreItemsResponse) batchResponse[0]).Count);
        }
    }
}
