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
    public class SetUserValuesUnitTest: RecombeeUnitTest
    {

        [Fact]
        public void TestSetUserValues()
        {
            SetUserValues req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail with existing entity and property'
            req = new SetUserValues("entity_id",new Dictionary<string, object>(){{"int_property",5}});
            resp = client.Send(req);
            // it 'does not fail with non-ASCII string'
            req = new SetUserValues("entity_id",new Dictionary<string, object>(){{"str_property","šřžذ的‎"}});
            resp = client.Send(req);
            // it 'sets multiple properties'
            req = new SetUserValues("entity_id",new Dictionary<string, object>(){{"int_property",5},{"str_property","test"}});
            resp = client.Send(req);
            // it 'does not fail with !cascadeCreate'
            req = new SetUserValues("new_entity",new Dictionary<string, object>(){{"int_property",5},{"str_property","test"},{"!cascadeCreate",true}});
            resp = client.Send(req);
            // it 'does not fail with cascadeCreate optional parameter'
            req = new SetUserValues("new_entity2",new Dictionary<string, object>(){{"int_property",5},{"str_property","test"}},cascadeCreate: true);
            resp = client.Send(req);
            // it 'fails with nonexisting entity'
            req = new SetUserValues("nonexisting",new Dictionary<string, object>(){{"int_property",5}});
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
    }
}
