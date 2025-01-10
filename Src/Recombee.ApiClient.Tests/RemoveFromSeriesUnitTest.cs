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
        public  void TestRemoveFromSeries()
        {
            RemoveFromSeries req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail when removing item that is contained in the set'
            resp = client.Send(new RemoveFromSeries("entity_id", "item", "entity_id"));
            // it 'fails when removing item that is not contained in the set'
            try
            {
                client.Send(new RemoveFromSeries("entity_id", "item", "not_contained"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestRemoveFromSeriesAsync()
        {
            RemoveFromSeries req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail when removing item that is contained in the set'
            resp = await client.SendAsync(new RemoveFromSeries("entity_id", "item", "entity_id"));
            // it 'fails when removing item that is not contained in the set'
            try
            {
                await client.SendAsync(new RemoveFromSeries("entity_id", "item", "not_contained"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }
    }
}
