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
    /// <summary>Search Item Segments</summary>
    /// <remarks>Full-text personalized search that returns Segments from a Segmentation. The results are based on the provided `searchQuery` and also on the user's past interactions (purchases, ratings, etc.).
    /// Based on the used Segmentation, this endpoint can be used for example for:
    ///   - Searching within categories or brands
    ///   - Searching within genres or artists
    /// For example if the user is searching for "iPhone" this endpoint can return "cell phones" category.
    /// You need to set the used Segmentation the Admin UI in the Scenario settings prior to using this endpoint.
    /// The returned segments are sorted by relevance (first segment being the most relevant).
    /// It is also possible to use POST HTTP method (for example in case of very long ReQL filter) - query parameters then become body parameters.
    /// </remarks>
    public class SearchItemSegments : Request
    {
        private readonly string userId;
        /// <summary>ID of the user for whom personalized search will be performed.</summary>
        public string UserId
        {
            get {return userId;}
        }
        private readonly string searchQuery;
        /// <summary>Search query provided by the user. It is used for the full-text search.</summary>
        public string SearchQuery
        {
            get {return searchQuery;}
        }
        private readonly long count;
        /// <summary>Number of segments to be returned (N for the top-N results).</summary>
        public long Count
        {
            get {return count;}
        }
        private readonly string scenario;
        /// <summary>Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </summary>
        public string Scenario
        {
            get {return scenario;}
        }
        private readonly bool? cascadeCreate;
        /// <summary>If the user does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows, for example, rotations in the following recommendations for that user, as the user will be already known to the system.
        /// </summary>
        public bool? CascadeCreate
        {
            get {return cascadeCreate;}
        }
        private readonly string filter;
        /// <summary>Boolean-returning [ReQL](https://docs.recombee.com/reql) expression which allows you to filter recommended segments based on the `segmentationId`.
        /// </summary>
        public string Filter
        {
            get {return filter;}
        }
        private readonly string booster;
        /// <summary>Number-returning [ReQL](https://docs.recombee.com/reql) expression which allows you to boost recommendation rate of some segments based on the `segmentationId`.
        /// </summary>
        public string Booster
        {
            get {return booster;}
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
        private readonly Dictionary<string, object> expertSettings;
        /// <summary>Dictionary of custom options.
        /// </summary>
        public Dictionary<string, object> ExpertSettings
        {
            get {return expertSettings;}
        }
        private readonly bool? returnAbGroup;
        /// <summary>If there is a custom AB-testing running, return the name of the group to which the request belongs.
        /// </summary>
        public bool? ReturnAbGroup
        {
            get {return returnAbGroup;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="userId">ID of the user for whom personalized search will be performed.</param>
        /// <param name="searchQuery">Search query provided by the user. It is used for the full-text search.</param>
        /// <param name="count">Number of segments to be returned (N for the top-N results).</param>
        /// <param name="scenario">Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </param>
        /// <param name="cascadeCreate">If the user does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows, for example, rotations in the following recommendations for that user, as the user will be already known to the system.
        /// </param>
        /// <param name="filter">Boolean-returning [ReQL](https://docs.recombee.com/reql) expression which allows you to filter recommended segments based on the `segmentationId`.
        /// </param>
        /// <param name="booster">Number-returning [ReQL](https://docs.recombee.com/reql) expression which allows you to boost recommendation rate of some segments based on the `segmentationId`.
        /// </param>
        /// <param name="logic">Logic specifies the particular behavior of the recommendation models. You can pick tailored logic for your domain and use case.
        /// See [this section](https://docs.recombee.com/recommendation_logics) for a list of available logics and other details.
        /// The difference between `logic` and `scenario` is that `logic` specifies mainly behavior, while `scenario` specifies the place where recommendations are shown to the users.
        /// Logic can also be set to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="expertSettings">Dictionary of custom options.
        /// </param>
        /// <param name="returnAbGroup">If there is a custom AB-testing running, return the name of the group to which the request belongs.
        /// </param>
        public SearchItemSegments (string userId, string searchQuery, long count, string scenario = null, bool? cascadeCreate = null, string filter = null, string booster = null, Logic logic = null, Dictionary<string, object> expertSettings = null, bool? returnAbGroup = null): base(HttpMethod.Post, 3000)
        {
            this.userId = userId;
            this.searchQuery = searchQuery;
            this.count = count;
            this.scenario = scenario;
            this.cascadeCreate = cascadeCreate;
            this.filter = filter;
            this.booster = booster;
            this.logic = logic;
            this.expertSettings = expertSettings;
            this.returnAbGroup = returnAbGroup;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/search/users/{0}/item-segments/", UserId);
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
                {"searchQuery", this.SearchQuery},
                {"count", this.Count}
            };
            if (this.Scenario != null)
                parameters["scenario"] = this.Scenario;
            if (this.CascadeCreate.HasValue)
                parameters["cascadeCreate"] = this.CascadeCreate.Value;
            if (this.Filter != null)
                parameters["filter"] = this.Filter;
            if (this.Booster != null)
                parameters["booster"] = this.Booster;
            if (this.Logic != null)
                parameters["logic"] = this.Logic;
            if (this.ExpertSettings != null)
                parameters["expertSettings"] = this.ExpertSettings;
            if (this.ReturnAbGroup.HasValue)
                parameters["returnAbGroup"] = this.ReturnAbGroup.Value;
            return parameters;
        }
    
    }
}
