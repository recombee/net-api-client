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
    public class SetUserValuesBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestSetUserValues()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new SetUserValues("entity_id", new Dictionary<string, object>(){{"int_property",5}}),
                new SetUserValues("entity_id", new Dictionary<string, object>(){{"str_property","šřžذ的‎"}}),
                new SetUserValues("entity_id", new Dictionary<string, object>(){{"int_property",5}, {"str_property","test"}}),
                new SetUserValues("new_entity", new Dictionary<string, object>(){{"int_property",5}, {"str_property","test"}, {"!cascadeCreate",true}}),
                new SetUserValues("new_entity2", new Dictionary<string, object>(){{"int_property",5}, {"str_property","test"}}, cascadeCreate: true),
                new SetUserValues("nonexisting", new Dictionary<string, object>(){{"int_property",5}})
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(3));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(4));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(5));
        }

        [Fact]
        public async void TestSetUserValuesAsync()
                {
            Object resp2;
            Request[] requests = new Request[] {
                new SetUserValues("entity_id", new Dictionary<string, object>(){{"int_property",5}}),
                new SetUserValues("entity_id", new Dictionary<string, object>(){{"str_property","šřžذ的‎"}}),
                new SetUserValues("entity_id", new Dictionary<string, object>(){{"int_property",5}, {"str_property","test"}}),
                new SetUserValues("new_entity", new Dictionary<string, object>(){{"int_property",5}, {"str_property","test"}, {"!cascadeCreate",true}}),
                new SetUserValues("new_entity2", new Dictionary<string, object>(){{"int_property",5}, {"str_property","test"}}, cascadeCreate: true),
                new SetUserValues("nonexisting", new Dictionary<string, object>(){{"int_property",5}})
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(3));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(4));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(5));
        }
    }
}
