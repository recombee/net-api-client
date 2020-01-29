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
    /// <summary>Search items</summary>
    /// <remarks>Full-text personalized search. The results are based on the provided `searchQuery` and also on the user's past interactions (purchases, ratings, etc.) with the items (items more suitable for the user are preferred in the results).
    /// All the string and set item properties are indexed by the search engine.
    /// This endpoint should be used in a search box at your website/app. It can be called multiple times as the user is typing the query in order to get the most viable suggestions based on current state of the query, or once after submitting the whole query. 
    /// It is also possible to use POST HTTP method (for example in case of very long ReQL filter) - query parameters then become body parameters.
    /// The returned items are sorted by relevancy (first item being the most relevant).
    /// </remarks>
    public class SearchItems : Request
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
        /// <summary>Number of items to be returned (N for the top-N results).</summary>
        public long Count
        {
            get {return count;}
        }
        private readonly string scenario;
        /// <summary>Scenario defines a particular search field in your user interface.
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios.html) in the [Admin UI](https://admin.recombee.com). You can also see performance of each scenario in the Admin UI separately, so you can check how well each field performs.
        /// The AI which optimizes models in order to get the best results may optimize different scenarios separately, or even use different models in each of the scenarios.
        /// </summary>
        public string Scenario
        {
            get {return scenario;}
        }
        private readonly bool? cascadeCreate;
        /// <summary>If the user does not exist in the database, returns a list of non-personalized search results and creates the user in the database. This allows for example rotations in the following recommendations for that user, as the user will be already known to the system.</summary>
        public bool? CascadeCreate
        {
            get {return cascadeCreate;}
        }
        private readonly bool? returnProperties;
        /// <summary>With `returnProperties=true`, property values of the recommended items are returned along with their IDs in a JSON dictionary. The acquired property values can be used for easy displaying of the recommended items to the user. 
        /// Example response:
        /// ```
        ///   {
        ///     "recommId": "ce52ada4-e4d9-4885-943c-407db2dee837",
        ///     "recomms": 
        ///       [
        ///         {
        ///           "id": "tv-178",
        ///           "values": {
        ///             "description": "4K TV with 3D feature",
        ///             "categories":   ["Electronics", "Televisions"],
        ///             "price": 342,
        ///             "url": "myshop.com/tv-178"
        ///           }
        ///         },
        ///         {
        ///           "id": "mixer-42",
        ///           "values": {
        ///             "description": "Stainless Steel Mixer",
        ///             "categories":   ["Home & Kitchen"],
        ///             "price": 39,
        ///             "url": "myshop.com/mixer-42"
        ///           }
        ///         }
        ///       ]
        ///   }
        /// ```
        /// </summary>
        public bool? ReturnProperties
        {
            get {return returnProperties;}
        }
        private readonly string[] includedProperties;
        /// <summary>Allows to specify, which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list. 
        /// Example response for `includedProperties=description,price`:
        /// ```
        ///   {
        ///     "recommId": "a86ee8d5-cd8e-46d1-886c-8b3771d0520b",
        ///     "recomms":
        ///       [
        ///         {
        ///           "id": "tv-178",
        ///           "values": {
        ///             "description": "4K TV with 3D feature",
        ///             "price": 342
        ///           }
        ///         },
        ///         {
        ///           "id": "mixer-42",
        ///           "values": {
        ///             "description": "Stainless Steel Mixer",
        ///             "price": 39
        ///           }
        ///         }
        ///       ]
        ///   }
        /// ```
        /// </summary>
        public string[] IncludedProperties
        {
            get {return includedProperties;}
        }
        private readonly string filter;
        /// <summary>Boolean-returning [ReQL](https://docs.recombee.com/reql.html) expression which allows you to filter recommended items based on the values of their attributes.
        /// Filters can be also assigned to a [scenario](https://docs.recombee.com/scenarios.html) in the [Admin UI](https://admin.recombee.com).
        /// </summary>
        public string Filter
        {
            get {return filter;}
        }
        private readonly string booster;
        /// <summary>Number-returning [ReQL](https://docs.recombee.com/reql.html) expression which allows you to boost recommendation rate of some items based on the values of their attributes.
        /// Boosters can be also assigned to a [scenario](https://docs.recombee.com/scenarios.html) in the [Admin UI](https://admin.recombee.com).
        /// </summary>
        public string Booster
        {
            get {return booster;}
        }
        private readonly Logic logic;
        /// <summary>Logic specifies particular behavior of the recommendation models. You can pick tailored logic for your domain and use case.
        /// See [this section](https://docs.recombee.com/recommendation_logics.html) for list of available logics and other details.
        /// The difference between `logic` and `scenario` is that `logic` specifies mainly behavior, while `scenario` specifies the place where recommendations are shown to the users.
        /// Logic can be also set to a [scenario](https://docs.recombee.com/scenarios.html) in the [Admin UI](https://admin.recombee.com).
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
        /// <summary>If there is a custom AB-testing running, return name of group to which the request belongs.
        /// </summary>
        public bool? ReturnAbGroup
        {
            get {return returnAbGroup;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="userId">ID of the user for whom personalized search will be performed.</param>
        /// <param name="searchQuery">Search query provided by the user. It is used for the full-text search.</param>
        /// <param name="count">Number of items to be returned (N for the top-N results).</param>
        /// <param name="scenario">Scenario defines a particular search field in your user interface.
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios.html) in the [Admin UI](https://admin.recombee.com). You can also see performance of each scenario in the Admin UI separately, so you can check how well each field performs.
        /// The AI which optimizes models in order to get the best results may optimize different scenarios separately, or even use different models in each of the scenarios.
        /// </param>
        /// <param name="cascadeCreate">If the user does not exist in the database, returns a list of non-personalized search results and creates the user in the database. This allows for example rotations in the following recommendations for that user, as the user will be already known to the system.</param>
        /// <param name="returnProperties">With `returnProperties=true`, property values of the recommended items are returned along with their IDs in a JSON dictionary. The acquired property values can be used for easy displaying of the recommended items to the user. 
        /// Example response:
        /// ```
        ///   {
        ///     "recommId": "ce52ada4-e4d9-4885-943c-407db2dee837",
        ///     "recomms": 
        ///       [
        ///         {
        ///           "id": "tv-178",
        ///           "values": {
        ///             "description": "4K TV with 3D feature",
        ///             "categories":   ["Electronics", "Televisions"],
        ///             "price": 342,
        ///             "url": "myshop.com/tv-178"
        ///           }
        ///         },
        ///         {
        ///           "id": "mixer-42",
        ///           "values": {
        ///             "description": "Stainless Steel Mixer",
        ///             "categories":   ["Home & Kitchen"],
        ///             "price": 39,
        ///             "url": "myshop.com/mixer-42"
        ///           }
        ///         }
        ///       ]
        ///   }
        /// ```
        /// </param>
        /// <param name="includedProperties">Allows to specify, which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list. 
        /// Example response for `includedProperties=description,price`:
        /// ```
        ///   {
        ///     "recommId": "a86ee8d5-cd8e-46d1-886c-8b3771d0520b",
        ///     "recomms":
        ///       [
        ///         {
        ///           "id": "tv-178",
        ///           "values": {
        ///             "description": "4K TV with 3D feature",
        ///             "price": 342
        ///           }
        ///         },
        ///         {
        ///           "id": "mixer-42",
        ///           "values": {
        ///             "description": "Stainless Steel Mixer",
        ///             "price": 39
        ///           }
        ///         }
        ///       ]
        ///   }
        /// ```
        /// </param>
        /// <param name="filter">Boolean-returning [ReQL](https://docs.recombee.com/reql.html) expression which allows you to filter recommended items based on the values of their attributes.
        /// Filters can be also assigned to a [scenario](https://docs.recombee.com/scenarios.html) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="booster">Number-returning [ReQL](https://docs.recombee.com/reql.html) expression which allows you to boost recommendation rate of some items based on the values of their attributes.
        /// Boosters can be also assigned to a [scenario](https://docs.recombee.com/scenarios.html) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="logic">Logic specifies particular behavior of the recommendation models. You can pick tailored logic for your domain and use case.
        /// See [this section](https://docs.recombee.com/recommendation_logics.html) for list of available logics and other details.
        /// The difference between `logic` and `scenario` is that `logic` specifies mainly behavior, while `scenario` specifies the place where recommendations are shown to the users.
        /// Logic can be also set to a [scenario](https://docs.recombee.com/scenarios.html) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="expertSettings">Dictionary of custom options.
        /// </param>
        /// <param name="returnAbGroup">If there is a custom AB-testing running, return name of group to which the request belongs.
        /// </param>
        public SearchItems (string userId, string searchQuery, long count, string scenario = null, bool? cascadeCreate = null, bool? returnProperties = null, string[] includedProperties = null, string filter = null, string booster = null, Logic logic = null, Dictionary<string, object> expertSettings = null, bool? returnAbGroup = null): base(HttpMethod.Post, 3000)
        {
            this.userId = userId;
            this.searchQuery = searchQuery;
            this.count = count;
            this.scenario = scenario;
            this.cascadeCreate = cascadeCreate;
            this.returnProperties = returnProperties;
            this.includedProperties = includedProperties;
            this.filter = filter;
            this.booster = booster;
            this.logic = logic;
            this.expertSettings = expertSettings;
            this.returnAbGroup = returnAbGroup;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/search/users/{0}/items/", UserId);
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
            if (this.ReturnProperties.HasValue)
                parameters["returnProperties"] = this.ReturnProperties.Value;
            if (this.IncludedProperties != null)
                parameters["includedProperties"] = string.Join(",", this.IncludedProperties);
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
