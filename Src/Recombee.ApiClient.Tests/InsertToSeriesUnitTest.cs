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
    public class InsertToSeriesUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestInsertToSeries()
        {
            InsertToSeries req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail when inserting existing item into existing set'
            req2 = new AddItem("new_item");
            client.Send(req2);
            req = new InsertToSeries("entity_id","item","new_item",3);
            resp = client.Send(req);
            // it 'does not fail when cascadeCreate is used'
            req = new InsertToSeries("new_set","item","new_item2",1,cascadeCreate: true);
            resp = client.Send(req);
            // it 'really inserts item to the set'
            req2 = new AddItem("new_item3");
            client.Send(req2);
            req = new InsertToSeries("entity_id","item","new_item3",2);
            resp = client.Send(req);
            try
            {
                client.Send(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestInsertToSeriesAsync()
        {
            InsertToSeries req;
            Request req2;
            RecombeeBinding resp;
            // it 'does not fail when inserting existing item into existing set'
            req2 = new AddItem("new_item");
            await client.SendAsync(req2);
            req = new InsertToSeries("entity_id","item","new_item",3);
            resp = await client.SendAsync(req);
            // it 'does not fail when cascadeCreate is used'
            req = new InsertToSeries("new_set","item","new_item2",1,cascadeCreate: true);
            resp = await client.SendAsync(req);
            // it 'really inserts item to the set'
            req2 = new AddItem("new_item3");
            await client.SendAsync(req2);
            req = new InsertToSeries("entity_id","item","new_item3",2);
            resp = await client.SendAsync(req);
            try
            {
                await client.SendAsync(req);
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }
    }
}
