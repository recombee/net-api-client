using System.Collections.Generic;
using System.Linq;
using Xunit;
using Recombee.ApiClient.ApiRequests;
using Recombee.ApiClient.Bindings;

namespace Recombee.ApiClient.Tests
{
    public class ItemBasedRecommendationUnitTest: RecommendationUnitTest
    {

        [Fact]
        public void TestBasicRecomm()
        {
            ItemBasedRecommendation req = new ItemBasedRecommendation("entity_id", 9);
            IEnumerable<Recommendation> response = client.Send(req);
            Assert.Equal(9, response.Count());
        }


        [Fact]
        public void TestRotation()
        {
            ItemBasedRecommendation req = new ItemBasedRecommendation("entity_id", 9, targetUserId: "entity_id");
            IEnumerable<Recommendation> recommended1 = client.Send(req);
            Assert.Equal(9, recommended1.Count());

            ItemBasedRecommendation req2 = new ItemBasedRecommendation("entity_id", 9, targetUserId: "entity_id", rotationRate: 1);
            IEnumerable<Recommendation> recommended2 = client.Send(req2);
            Assert.Equal(9, recommended2.Count());

            var ids1 = recommended1.Select(rec => rec.Id);
            var ids2 = recommended2.Select(rec => rec.Id);

            foreach(var id in ids1)
                Assert.False(ids2.Contains(id));
        }

        [Fact]
        public void TestInBatch()
        {
            const int NUM = 25;
            var reqs = Enumerable.Range(0, NUM).Select(_ => new ItemBasedRecommendation("entity_id", 9));
            client.Send(new Batch(reqs));
        }

        [Fact]
        public void TestReturningProperties()
        {
            ItemBasedRecommendation req = new ItemBasedRecommendation("entity_id", 9, returnProperties: true, includedProperties: new string[] {"answer", "id2", "empty"});
            IEnumerable<Recommendation> recommended = client.Send(req);
            foreach(var r in recommended)
            {
                Assert.Equal(r.Id, r.Values["id2"]);
                Assert.Equal((long)42, (long)r.Values["answer"]);
                Assert.True(r.Values.ContainsKey("empty"));

            }


            ItemBasedRecommendation req2 = new ItemBasedRecommendation("entity_id", 9, returnProperties: true, includedProperties: new string[] {"answer", "id2"});
            IEnumerable<Recommendation> recommended2 = client.Send(req2);
            foreach(var r in recommended2)
            {
                Assert.Equal(r.Id, r.Values["id2"]);
                Assert.Equal((long)42, (long)r.Values["answer"]);
                Assert.False(r.Values.ContainsKey("empty"));
            }
        }

    }
}