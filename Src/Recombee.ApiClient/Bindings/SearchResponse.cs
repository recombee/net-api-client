namespace Recombee.ApiClient.Bindings
{
    /// <summary>SearchResponse Binding</summary>
    public class SearchResponse: RecommendationResponse {
        public SearchResponse (string recommId, Recommendation[] recomms, int numberNextRecommsCalls=0, string abGroup=null): base(recommId, recomms, numberNextRecommsCalls, abGroup)
        {}
    }
}
