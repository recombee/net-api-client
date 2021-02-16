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
    public class AddSearchSynonymUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestAddSearchSynonym()
        {
            AddSearchSynonym req;
            SearchSynonym resp;
            Object resp2;
            // it 'adds search synonym'
            resp = client.Send(new AddSearchSynonym("sci-fi", "science fiction", oneWay: true));
            Assert.Equal ("sci-fi",resp.Term);
            Assert.Equal ("science fiction",resp.Synonym);
            try
            {
                client.Send(new AddSearchSynonym("sci-fi", "science fiction", oneWay: true));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }

        [Fact]
        public async void TestAddSearchSynonymAsync()
        {
            AddSearchSynonym req;
            SearchSynonym resp;
            Object resp2;
            // it 'adds search synonym'
            resp = await client.SendAsync(new AddSearchSynonym("sci-fi", "science fiction", oneWay: true));
            Assert.Equal ("sci-fi",resp.Term);
            Assert.Equal ("science fiction",resp.Synonym);
            try
            {
                await client.SendAsync(new AddSearchSynonym("sci-fi", "science fiction", oneWay: true));
                Assert.True(false,"No exception thrown");
            }
            catch (ResponseException ex)
            {
                Assert.Equal(409, (int)ex.StatusCode);
            }
        }
    }
}
