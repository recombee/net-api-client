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
    public class SetItemValuesUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestSetItemValues()
        {
            SetItemValues req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail with existing entity and property'
            req = new SetItemValues("entity_id",new Dictionary<string, object>(){{"int_property",5}});
            resp = client.Send(req);
            // it 'does not fail with non-ASCII string'
            req = new SetItemValues("entity_id",new Dictionary<string, object>(){{"str_property","šřžذ的‎"}});
            resp = client.Send(req);
            // it 'sets multiple properties'
            req = new SetItemValues("entity_id",new Dictionary<string, object>(){{"int_property",5},{"str_property","test"}});
            resp = client.Send(req);
            // it 'does not fail with !cascadeCreate'
            req = new SetItemValues("new_entity",new Dictionary<string, object>(){{"int_property",5},{"str_property","test"},{"!cascadeCreate",true}});
            resp = client.Send(req);
            // it 'does not fail with cascadeCreate optional parameter'
            req = new SetItemValues("new_entity2",new Dictionary<string, object>(){{"int_property",5},{"str_property","test"}},cascadeCreate: true);
            resp = client.Send(req);
            // it 'fails with nonexisting entity'
            req = new SetItemValues("nonexisting",new Dictionary<string, object>(){{"int_property",5}});
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
        public async void TestSetItemValuesAsync()
        {
            SetItemValues req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail with existing entity and property'
            req = new SetItemValues("entity_id",new Dictionary<string, object>(){{"int_property",5}});
            resp = await client.SendAsync(req);
            // it 'does not fail with non-ASCII string'
            req = new SetItemValues("entity_id",new Dictionary<string, object>(){{"str_property","šřžذ的‎"}});
            resp = await client.SendAsync(req);
            // it 'sets multiple properties'
            req = new SetItemValues("entity_id",new Dictionary<string, object>(){{"int_property",5},{"str_property","test"}});
            resp = await client.SendAsync(req);
            // it 'does not fail with !cascadeCreate'
            req = new SetItemValues("new_entity",new Dictionary<string, object>(){{"int_property",5},{"str_property","test"},{"!cascadeCreate",true}});
            resp = await client.SendAsync(req);
            // it 'does not fail with cascadeCreate optional parameter'
            req = new SetItemValues("new_entity2",new Dictionary<string, object>(){{"int_property",5},{"str_property","test"}},cascadeCreate: true);
            resp = await client.SendAsync(req);
            // it 'fails with nonexisting entity'
            req = new SetItemValues("nonexisting",new Dictionary<string, object>(){{"int_property",5}});
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
