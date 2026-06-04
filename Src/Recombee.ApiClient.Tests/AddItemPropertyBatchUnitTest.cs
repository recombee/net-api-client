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
    public class AddItemPropertyBatchUnitTest: RecombeeUnitTest
    {

        [Fact]
        public  void TestAddItemProperty()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new AddItemProperty("number", "int"),
                new AddItemProperty("str", "string"),
                new AddItemProperty("prop", "integer"),
                new AddItemProperty("number2", "int"),
                new AddItemProperty("number2", "int"),
                new AddItemProperty("title", "string", role: new PropertyRole("title")),
                new AddItemProperty("str4", "string", role: new PropertyRole("summary")),
                new AddItemProperty("str4", "string", role: new PropertyRole("summary")),
                new AddItemProperty("str5", "string", role: new PropertyRole("titl"))
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(3));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(4));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(5));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(6));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(7));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(8));
        }

        [Fact]
        public async void TestAddItemPropertyAsync()
        {
            Object resp2;
            Request[] requests = new Request[] {
                new AddItemProperty("number", "int"),
                new AddItemProperty("str", "string"),
                new AddItemProperty("prop", "integer"),
                new AddItemProperty("number2", "int"),
                new AddItemProperty("number2", "int"),
                new AddItemProperty("title", "string", role: new PropertyRole("title")),
                new AddItemProperty("str4", "string", role: new PropertyRole("summary")),
                new AddItemProperty("str4", "string", role: new PropertyRole("summary")),
                new AddItemProperty("str5", "string", role: new PropertyRole("titl"))
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(1));
            Assert.Equal(400, (int)batchResponse.StatusCodes.ElementAt(2));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(3));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(4));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(5));
            Assert.Equal(201, (int)batchResponse.StatusCodes.ElementAt(6));
            Assert.Equal(409, (int)batchResponse.StatusCodes.ElementAt(7));
            Assert.Equal(404, (int)batchResponse.StatusCodes.ElementAt(8));
        }
    }
}
