/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using Recombee.ApiClient.Bindings;
using Recombee.ApiClient.Util;


namespace Recombee.ApiClient.ApiRequests
{
    /// <summary>Composite Recommendation</summary>
    /// <remarks>Composite Recommendation returns both a *source entity* (e.g., an Item or [Item Segment](https://docs.recombee.com/segmentations)) and a list of related recommendations in a single response.
    /// It is ideal for use cases such as personalized homepage sections (*Articles from <category>*), *Because You Watched <movie>*, or *Artists Related to Your Favorite Artist <artist>*.
    /// See detailed **examples and configuration guidance** in the [Composite Scenarios documentation](https://docs.recombee.com/scenarios#composite-recommendations).
    /// **Structure**
    /// The endpoint operates in two stages:
    /// 1. Recommends the *source* (e.g., an Item Segment or item) to the user.
    /// 2. Recommends *results* (items or Item Segments) related to that *source*.
    /// For example, *Articles from <category>* can be decomposed into:
    ///   - [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-item-segments-to-user) to find the category.
    ///   - [Recommend Items To Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment) to recommend articles from that category.
    /// Since the first step uses [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-items-to-user), you must include the `userId` parameter in the *Composite Recommendation* request.
    /// Each *Composite Recommendation* counts as a single recommendation API request for billing.
    /// **Stage-specific Parameters**
    /// Additional parameters can be supplied via [sourceSettings](https://docs.recombee.com/api#composite-recommendation-param-sourceSettings) and [resultSettings](https://docs.recombee.com/api#composite-recommendation-param-resultSettings).
    /// In the example above:
    ///   - `sourceSettings` may include any parameter valid for [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-items-to-user) (e.g., `filter`, `booster`).
    ///   - `resultSettings` may include any parameter valid for [Recommend Items To Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment).
    /// See [this example](https://docs.recombee.com/api#composite-recommendation-example-setting-parameters-for-individual-stages) for more details.
    /// </remarks>
    public class CompositeRecommendation : Request
    {
        private readonly string scenario;
        /// <summary>Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </summary>
        public string Scenario
        {
            get {return scenario;}
        }
        private readonly long count;
        /// <summary>Number of items to be recommended (N for the top-N recommendation).
        /// </summary>
        public long Count
        {
            get {return count;}
        }
        private readonly string itemId;
        /// <summary>ID of the item for which the recommendations are to be generated.
        /// </summary>
        public string ItemId
        {
            get {return itemId;}
        }
        private readonly string userId;
        /// <summary>ID of the user for which the recommendations are to be generated.
        /// </summary>
        public string UserId
        {
            get {return userId;}
        }
        private readonly Logic logic;
        /// <summary>Logic specifies the particular behavior of the recommendation models. You can pick tailored logic for your domain and use case.
        /// See [this section](https://docs.recombee.com/recommendation_logics) for a list of available logics and other details.
        /// The difference between `logic` and `scenario` is that `logic` specifies mainly behavior, while `scenario` specifies the place where recommendations are shown to the users.
        /// Logic can also be set to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </summary>
        public Logic Logic
        {
            get {return logic;}
        }
        private readonly string segmentId;
        /// <summary>ID of the segment from `contextSegmentationId` for which the recommendations are to be generated.
        /// </summary>
        public string SegmentId
        {
            get {return segmentId;}
        }
        private readonly string searchQuery;
        /// <summary>Search query provided by the user. It is used for the full-text search. Only applicable if the *scenario* corresponds to a search scenario.
        /// </summary>
        public string SearchQuery
        {
            get {return searchQuery;}
        }
        private readonly bool? cascadeCreate;
        /// <summary>If the entity for the source recommendation does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows, for example, rotations in the following recommendations for that entity, as the entity will be already known to the system.
        /// </summary>
        public bool? CascadeCreate
        {
            get {return cascadeCreate;}
        }
        private readonly CompositeRecommendationStageParameters sourceSettings;
        /// <summary>Parameters applied for recommending the *Source* stage. The accepted parameters correspond with the recommendation sub-endpoint used to recommend the *Source*.
        /// </summary>
        public CompositeRecommendationStageParameters SourceSettings
        {
            get {return sourceSettings;}
        }
        private readonly CompositeRecommendationStageParameters resultSettings;
        /// <summary>Parameters applied for recommending the *Result* stage. The accepted parameters correspond with the recommendation sub-endpoint used to recommend the *Result*.
        /// </summary>
        public CompositeRecommendationStageParameters ResultSettings
        {
            get {return resultSettings;}
        }
        private readonly Dictionary<string, object> expertSettings;
        /// <summary>Dictionary of custom options.
        /// </summary>
        public Dictionary<string, object> ExpertSettings
        {
            get {return expertSettings;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="scenario">Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </param>
        /// <param name="count">Number of items to be recommended (N for the top-N recommendation).
        /// </param>
        /// <param name="itemId">ID of the item for which the recommendations are to be generated.
        /// </param>
        /// <param name="userId">ID of the user for which the recommendations are to be generated.
        /// </param>
        /// <param name="logic">Logic specifies the particular behavior of the recommendation models. You can pick tailored logic for your domain and use case.
        /// See [this section](https://docs.recombee.com/recommendation_logics) for a list of available logics and other details.
        /// The difference between `logic` and `scenario` is that `logic` specifies mainly behavior, while `scenario` specifies the place where recommendations are shown to the users.
        /// Logic can also be set to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="segmentId">ID of the segment from `contextSegmentationId` for which the recommendations are to be generated.
        /// </param>
        /// <param name="searchQuery">Search query provided by the user. It is used for the full-text search. Only applicable if the *scenario* corresponds to a search scenario.
        /// </param>
        /// <param name="cascadeCreate">If the entity for the source recommendation does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows, for example, rotations in the following recommendations for that entity, as the entity will be already known to the system.
        /// </param>
        /// <param name="sourceSettings">Parameters applied for recommending the *Source* stage. The accepted parameters correspond with the recommendation sub-endpoint used to recommend the *Source*.
        /// </param>
        /// <param name="resultSettings">Parameters applied for recommending the *Result* stage. The accepted parameters correspond with the recommendation sub-endpoint used to recommend the *Result*.
        /// </param>
        /// <param name="expertSettings">Dictionary of custom options.
        /// </param>
        public CompositeRecommendation (string scenario, long count, string itemId = null, string userId = null, Logic logic = null, string segmentId = null, string searchQuery = null, bool? cascadeCreate = null, CompositeRecommendationStageParameters sourceSettings = null, CompositeRecommendationStageParameters resultSettings = null, Dictionary<string, object> expertSettings = null): base(HttpMethod.Post, 3000)
        {
            this.scenario = scenario;
            this.count = count;
            this.itemId = itemId;
            this.userId = userId;
            this.logic = logic;
            this.segmentId = segmentId;
            this.searchQuery = searchQuery;
            this.cascadeCreate = cascadeCreate;
            this.sourceSettings = sourceSettings;
            this.resultSettings = resultSettings;
            this.expertSettings = expertSettings;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/recomms/composite/";
        }
    
        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> QueryParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
        
            };
            return parameters;
        }
    
        /// <summary>Get body parameters</summary>
        /// <returns>Dictionary containing  values of body parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> BodyParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
                {"scenario", this.Scenario},
                {"count", this.Count}
            };
            if (this.ItemId != null)
                parameters["itemId"] = this.ItemId;
            if (this.UserId != null)
                parameters["userId"] = this.UserId;
            if (this.Logic != null)
                parameters["logic"] = this.Logic;
            if (this.SegmentId != null)
                parameters["segmentId"] = this.SegmentId;
            if (this.SearchQuery != null)
                parameters["searchQuery"] = this.SearchQuery;
            if (this.CascadeCreate.HasValue)
                parameters["cascadeCreate"] = this.CascadeCreate.Value;
            if (this.SourceSettings != null)
                parameters["sourceSettings"] = this.SourceSettings;
            if (this.ResultSettings != null)
                parameters["resultSettings"] = this.ResultSettings;
            if (this.ExpertSettings != null)
                parameters["expertSettings"] = this.ExpertSettings;
            return parameters;
        }
    
    }
}
