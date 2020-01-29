namespace Recombee.ApiClient.Bindings
{
    /// <summary>SearchResponse Binding</summary>
    public class SearchResponse: RecommendationResponse {
        public SearchResponse (string recommId, Recommendation[] recomms, string abGroup=null): base(recommId, recomms, abGroup)
        {}
    }
}
