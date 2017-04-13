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
    public class RemoveFromSeriesUnitTest: RecombeeUnitTest
    {

        [Fact]
        public void TestRemoveFromSeries()
        {
            RemoveFromSeries req;
            Request req2;
            RecombeeBinding resp;
            // it 'fails when removing item which have different time'
            req = new RemoveFromSeries("entity_id","item","entity_id",0);
            try
            {
                client.Send(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
            // it 'does not fail when removing item that is contained in the set'
            req = new RemoveFromSeries("entity_id","item","entity_id",1);
            resp = client.Send(req);
            // it 'fails when removing item that is not contained in the set'
            req = new RemoveFromSeries("entity_id","item","not_contained",1);
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
