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
    public class InsertToGroupUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestInsertToGroup()
        {
            InsertToGroup req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail when inserting existing item into existing set'
            resp2 = client.Send(new AddItem("new_item"));
            resp = client.Send(new InsertToGroup("entity_id", "item", "new_item"));
            // it 'does not fail when cascadeCreate is used'
            resp = client.Send(new InsertToGroup("new_set", "item", "new_item2", cascadeCreate: true));
            // it 'really inserts item to the set'
            resp2 = client.Send(new AddItem("new_item3"));
            resp = client.Send(new InsertToGroup("entity_id", "item", "new_item3"));
            try
            {
                client.Send(new InsertToGroup("entity_id", "item", "new_item3"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestInsertToGroupAsync()
        {
            InsertToGroup req;
            RecombeeBinding resp;
            Object resp2;
            // it 'does not fail when inserting existing item into existing set'
            resp2 = await client.SendAsync(new AddItem("new_item"));
            resp = await client.SendAsync(new InsertToGroup("entity_id", "item", "new_item"));
            // it 'does not fail when cascadeCreate is used'
            resp = await client.SendAsync(new InsertToGroup("new_set", "item", "new_item2", cascadeCreate: true));
            // it 'really inserts item to the set'
            resp2 = await client.SendAsync(new AddItem("new_item3"));
            resp = await client.SendAsync(new InsertToGroup("entity_id", "item", "new_item3"));
            try
            {
                await client.SendAsync(new InsertToGroup("entity_id", "item", "new_item3"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }
    }
}
