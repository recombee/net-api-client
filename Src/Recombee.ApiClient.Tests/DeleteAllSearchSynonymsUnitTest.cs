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
    public class DeleteAllSearchSynonymsUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestDeleteAllSearchSynonyms()
        {
            DeleteAllSearchSynonyms req;
            RecombeeBinding resp;
            Object resp2;
            // it 'deletes all search synonyms'
            resp = client.Send(new DeleteAllSearchSynonyms());
        }

        [Fact]
        public async void TestDeleteAllSearchSynonymsAsync()
        {
            DeleteAllSearchSynonyms req;
            RecombeeBinding resp;
            Object resp2;
            // it 'deletes all search synonyms'
            resp = await client.SendAsync(new DeleteAllSearchSynonyms());
        }
    }
}
