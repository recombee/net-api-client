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
    /// <summary>Recommend items to user</summary>
    /// <remarks>Based on user's past interactions (purchases, ratings, etc.) with the items, recommends top-N items that are most likely to be of high value for a given user.
    /// The most typical use cases are recommendations at homepage, in some "Picked just for you" section or in email.
    /// The returned items are sorted by relevance (first item being the most relevant).
    /// Besides the recommended items, also a unique `recommId` is returned in the response. It can be used to:
    /// - Let Recombee know that this recommendation was successful (e.g. user clicked one of the recommended items). See [Reported metrics](https://docs.recombee.com/admin_ui.html#reported-metrics).
    /// - Get subsequent recommended items when the user scrolls down (*infinite scroll*) or goes to the next page. See [Recommend Next Items](https://docs.recombee.com/api.html#recommend-next-items).
    /// It is also possible to use POST HTTP method (for example in case of very long ReQL filter) - query parameters then become body parameters.
    /// </remarks>
    public class RecommendItemsToUser : Request
    {
        private readonly string userId;
        /// <summary>ID of the user for whom personalized recommendations are to be generated.</summary>
        public string UserId
        {
            get {return userId;}
        }
        private readonly long count;
        /// <summary>Number of items to be recommended (N for the top-N recommendation).
        /// </summary>
        public long Count
        {
            get {return count;}
        }
        private readonly string scenario;
        /// <summary>Scenario defines a particular application of recommendations. It can be for example "homepage", "cart" or "emailing".
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios.html) in the [Admin UI](https://admin.recombee.com). You can also see performance of each scenario in the Admin UI separately, so you can check how well each application performs.
        /// The AI which optimizes models in order to get the best results may optimize different scenarios separately, or even use different models in each of the scenarios.
        /// </summary>
        public string Scenario
        {
            get {return scenario;}
        }
        private readonly bool? cascadeCreate;
        /// <summary>If the user does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows for example rotations in the following recommendations for that user, as the user will be already known to the system.
        /// </summary>
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
        ///       ],
        ///      "numberNextRecommsCalls": 0
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
        ///       ],
        ///     "numberNextRecommsCalls": 0
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
        private readonly double? diversity;
        /// <summary>**Expert option** Real number from [0.0, 1.0] which determines how much mutually dissimilar should the recommended items be. The default value is 0.0, i.e., no diversification. Value 1.0 means maximal diversification.
        /// </summary>
        public double? Diversity
        {
            get {return diversity;}
        }
        private readonly string minRelevance;
        /// <summary>**Expert option** Specifies the threshold of how much relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend number of items equal to *count* at any cost. If there are not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations to be appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such case, the system only recommends items of at least the requested relevance, and may return less than *count* items when there is not enough data to fulfill it.
        /// </summary>
        public string MinRelevance
        {
            get {return minRelevance;}
        }
        private readonly double? rotationRate;
        /// <summary>**Expert option** If your users browse the system in real-time, it may easily happen that you wish to offer them recommendations multiple times. Here comes the question: how much should the recommendations change? Should they remain the same, or should they rotate? Recombee API allows you to control this per-request in backward fashion. You may penalize an item for being recommended in the near past. For the specific user, `rotationRate=1` means maximal rotation, `rotationRate=0` means absolutely no rotation. You may also use, for example `rotationRate=0.2` for only slight rotation of recommended items. Default: `0`.
        /// </summary>
        public double? RotationRate
        {
            get {return rotationRate;}
        }
        private readonly double? rotationTime;
        /// <summary>**Expert option** Taking *rotationRate* into account, specifies how long time it takes to an item to recover from the penalization. For example, `rotationTime=7200.0` means that items recommended less than 2 hours ago are penalized. Default: `7200.0`.
        /// </summary>
        public double? RotationTime
        {
            get {return rotationTime;}
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
        /// <param name="userId">ID of the user for whom personalized recommendations are to be generated.</param>
        /// <param name="count">Number of items to be recommended (N for the top-N recommendation).
        /// </param>
        /// <param name="scenario">Scenario defines a particular application of recommendations. It can be for example "homepage", "cart" or "emailing".
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios.html) in the [Admin UI](https://admin.recombee.com). You can also see performance of each scenario in the Admin UI separately, so you can check how well each application performs.
        /// The AI which optimizes models in order to get the best results may optimize different scenarios separately, or even use different models in each of the scenarios.
        /// </param>
        /// <param name="cascadeCreate">If the user does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows for example rotations in the following recommendations for that user, as the user will be already known to the system.
        /// </param>
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
        ///       ],
        ///      "numberNextRecommsCalls": 0
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
        ///       ],
        ///     "numberNextRecommsCalls": 0
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
        /// <param name="diversity">**Expert option** Real number from [0.0, 1.0] which determines how much mutually dissimilar should the recommended items be. The default value is 0.0, i.e., no diversification. Value 1.0 means maximal diversification.
        /// </param>
        /// <param name="minRelevance">**Expert option** Specifies the threshold of how much relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend number of items equal to *count* at any cost. If there are not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations to be appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such case, the system only recommends items of at least the requested relevance, and may return less than *count* items when there is not enough data to fulfill it.
        /// </param>
        /// <param name="rotationRate">**Expert option** If your users browse the system in real-time, it may easily happen that you wish to offer them recommendations multiple times. Here comes the question: how much should the recommendations change? Should they remain the same, or should they rotate? Recombee API allows you to control this per-request in backward fashion. You may penalize an item for being recommended in the near past. For the specific user, `rotationRate=1` means maximal rotation, `rotationRate=0` means absolutely no rotation. You may also use, for example `rotationRate=0.2` for only slight rotation of recommended items. Default: `0`.
        /// </param>
        /// <param name="rotationTime">**Expert option** Taking *rotationRate* into account, specifies how long time it takes to an item to recover from the penalization. For example, `rotationTime=7200.0` means that items recommended less than 2 hours ago are penalized. Default: `7200.0`.
        /// </param>
        /// <param name="expertSettings">Dictionary of custom options.
        /// </param>
        /// <param name="returnAbGroup">If there is a custom AB-testing running, return name of group to which the request belongs.
        /// </param>
        public RecommendItemsToUser (string userId, long count, string scenario = null, bool? cascadeCreate = null, bool? returnProperties = null, string[] includedProperties = null, string filter = null, string booster = null, Logic logic = null, double? diversity = null, string minRelevance = null, double? rotationRate = null, double? rotationTime = null, Dictionary<string, object> expertSettings = null, bool? returnAbGroup = null): base(HttpMethod.Post, 3000)
        {
            this.userId = userId;
            this.count = count;
            this.scenario = scenario;
            this.cascadeCreate = cascadeCreate;
            this.returnProperties = returnProperties;
            this.includedProperties = includedProperties;
            this.filter = filter;
            this.booster = booster;
            this.logic = logic;
            this.diversity = diversity;
            this.minRelevance = minRelevance;
            this.rotationRate = rotationRate;
            this.rotationTime = rotationTime;
            this.expertSettings = expertSettings;
            this.returnAbGroup = returnAbGroup;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/recomms/users/{0}/items/", UserId);
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
            if (this.Diversity.HasValue)
                parameters["diversity"] = this.Diversity.Value;
            if (this.MinRelevance != null)
                parameters["minRelevance"] = this.MinRelevance;
            if (this.RotationRate.HasValue)
                parameters["rotationRate"] = this.RotationRate.Value;
            if (this.RotationTime.HasValue)
                parameters["rotationTime"] = this.RotationTime.Value;
            if (this.ExpertSettings != null)
                parameters["expertSettings"] = this.ExpertSettings;
            if (this.ReturnAbGroup.HasValue)
                parameters["returnAbGroup"] = this.ReturnAbGroup.Value;
            return parameters;
        }
    
    }
}
