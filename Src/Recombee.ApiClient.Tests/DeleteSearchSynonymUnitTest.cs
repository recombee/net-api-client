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
    public class DeleteSearchSynonymUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestDeleteSearchSynonym()
        {
            DeleteSearchSynonym req;
            RecombeeBinding resp;
            Object resp2;
            // it 'deletes search synonym'
            resp2 = client.Send(new AddSearchSynonym("sci-fi", "science fiction"));
            resp = client.Send(new DeleteSearchSynonym(((SearchSynonym)resp2).Id));
            try
            {
                client.Send(new DeleteSearchSynonym("a968271b-d666-4dfb-8a30-f459e564ba7b"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestDeleteSearchSynonymAsync()
        {
            DeleteSearchSynonym req;
            RecombeeBinding resp;
            Object resp2;
            // it 'deletes search synonym'
            resp2 = await client.SendAsync(new AddSearchSynonym("sci-fi", "science fiction"));
            resp = await client.SendAsync(new DeleteSearchSynonym(((SearchSynonym)resp2).Id));
            try
            {
                await client.SendAsync(new DeleteSearchSynonym("a968271b-d666-4dfb-8a30-f459e564ba7b"));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(404, (int)ex.StatusCode);
            }
        }
    }
}
