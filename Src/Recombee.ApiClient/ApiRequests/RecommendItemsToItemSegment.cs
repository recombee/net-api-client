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
    /// <summary>Recommend Items to Item Segment</summary>
    /// <remarks>Recommends Items that are the most relevant to a particular Segment from a context [Segmentation](https://docs.recombee.com/segmentations).
    /// Based on the used Segmentation, this endpoint can be used for example for:
    /// - Recommending articles related to a particular topic
    /// - Recommending songs belonging to a particular genre
    /// - Recommending products produced by a particular brand
    /// You need to set the used context Segmentation in the Admin UI in the [Scenario settings](https://docs.recombee.com/scenarios) prior to using this endpoint.
    /// The returned items are sorted by relevance (the first item being the most relevant).
    /// It is also possible to use the POST HTTP method (for example, in the case of a very long ReQL filter) — query parameters then become body parameters.
    /// </remarks>
    public class RecommendItemsToItemSegment : Request
    {
        private readonly string contextSegmentId;
        /// <summary>ID of the segment from `contextSegmentationId` for which the recommendations are to be generated.</summary>
        public string ContextSegmentId
        {
            get {return contextSegmentId;}
        }
        private readonly string targetUserId;
        /// <summary>ID of the user who will see the recommendations.
        /// Specifying the *targetUserId* is beneficial because:
        /// * It makes the recommendations personalized
        /// * Allows the calculation of Actions and Conversions
        ///   in the graphical user interface,
        ///   as Recombee can pair the user who got recommendations
        ///   and who afterward viewed/purchased an item.
        /// If you insist on not specifying the user, pass `null`
        /// (`None`, `nil`, `NULL` etc., depending on the language) to *targetUserId*.
        /// Do not create some special dummy user for getting recommendations,
        /// as it could mislead the recommendation models,
        /// and result in wrong recommendations.
        /// For anonymous/unregistered users, it is possible to use, for example, their session ID.
        /// </summary>
        public string TargetUserId
        {
            get {return targetUserId;}
        }
        private readonly long count;
        /// <summary>Number of items to be recommended (N for the top-N recommendation).</summary>
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
        /// <summary>If a user of the given *targetUserId* doesn't exist in the database, it creates this user and returns some (non-personalized) recommendations. This allows, for example, rotations in the following recommendations for the user of the given *targetUserId*, as the user will be already known to the system.</summary>
        public bool? CascadeCreate
        {
            get {return cascadeCreate;}
        }
        private readonly bool? returnProperties;
        /// <summary>With `returnProperties=true`, property values of the recommended items are returned along with their IDs in a JSON dictionary. The acquired property values can be used to easily display the recommended items to the user. 
        /// Example response:
        /// ```json
        ///   {
        ///     "recommId": "0c6189e7-dc1a-429a-b613-192696309361",
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
        ///     "numberNextRecommsCalls": 0
        ///   }
        /// ```
        /// </summary>
        public bool? ReturnProperties
        {
            get {return returnProperties;}
        }
        private readonly string[] includedProperties;
        /// <summary>Allows specifying which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list.
        /// Example response for `includedProperties=description,price`:
        /// ```json
        ///   {
        ///     "recommId": "6842c725-a79f-4537-a02c-f34d668a3f80",
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
        /// <summary>Boolean-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to filter recommended items based on the values of their attributes.
        /// Filters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </summary>
        public string Filter
        {
            get {return filter;}
        }
        private readonly string booster;
        /// <summary>Number-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to boost the recommendation rate of some items based on the values of their attributes.
        /// Boosters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
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
        private readonly string minRelevance;
        /// <summary>**Expert option:** If the *targetUserId* is provided:  Specifies the threshold of how relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend a number of items equal to *count* at any cost. If there is not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations being appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such case, the system only recommends items of at least the requested relevance and may return less than *count* items when there is not enough data to fulfill it.
        /// </summary>
        public string MinRelevance
        {
            get {return minRelevance;}
        }
        private readonly double? rotationRate;
        /// <summary>**Expert option:** If the *targetUserId* is provided: If your users browse the system in real-time, it may easily happen that you wish to offer them recommendations multiple times. Here comes the question: how much should the recommendations change? Should they remain the same, or should they rotate? Recombee API allows you to control this per request in a backward fashion. You may penalize an item for being recommended in the near past. For the specific user, `rotationRate=1` means maximal rotation, `rotationRate=0` means absolutely no rotation. You may also use, for example, `rotationRate=0.2` for only slight rotation of recommended items.
        /// </summary>
        public double? RotationRate
        {
            get {return rotationRate;}
        }
        private readonly double? rotationTime;
        /// <summary>**Expert option:** If the *targetUserId* is provided: Taking *rotationRate* into account, specifies how long it takes for an item to recover from the penalization. For example, `rotationTime=7200.0` means that items recommended less than 2 hours ago are penalized.
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
        /// <summary>If there is a custom AB-testing running, return the name of the group to which the request belongs.
        /// </summary>
        public bool? ReturnAbGroup
        {
            get {return returnAbGroup;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="contextSegmentId">ID of the segment from `contextSegmentationId` for which the recommendations are to be generated.</param>
        /// <param name="targetUserId">ID of the user who will see the recommendations.
        /// Specifying the *targetUserId* is beneficial because:
        /// * It makes the recommendations personalized
        /// * Allows the calculation of Actions and Conversions
        ///   in the graphical user interface,
        ///   as Recombee can pair the user who got recommendations
        ///   and who afterward viewed/purchased an item.
        /// If you insist on not specifying the user, pass `null`
        /// (`None`, `nil`, `NULL` etc., depending on the language) to *targetUserId*.
        /// Do not create some special dummy user for getting recommendations,
        /// as it could mislead the recommendation models,
        /// and result in wrong recommendations.
        /// For anonymous/unregistered users, it is possible to use, for example, their session ID.
        /// </param>
        /// <param name="count">Number of items to be recommended (N for the top-N recommendation).</param>
        /// <param name="scenario">Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </param>
        /// <param name="cascadeCreate">If a user of the given *targetUserId* doesn't exist in the database, it creates this user and returns some (non-personalized) recommendations. This allows, for example, rotations in the following recommendations for the user of the given *targetUserId*, as the user will be already known to the system.</param>
        /// <param name="returnProperties">With `returnProperties=true`, property values of the recommended items are returned along with their IDs in a JSON dictionary. The acquired property values can be used to easily display the recommended items to the user. 
        /// Example response:
        /// ```json
        ///   {
        ///     "recommId": "0c6189e7-dc1a-429a-b613-192696309361",
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
        ///     "numberNextRecommsCalls": 0
        ///   }
        /// ```
        /// </param>
        /// <param name="includedProperties">Allows specifying which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list.
        /// Example response for `includedProperties=description,price`:
        /// ```json
        ///   {
        ///     "recommId": "6842c725-a79f-4537-a02c-f34d668a3f80",
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
        /// <param name="filter">Boolean-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to filter recommended items based on the values of their attributes.
        /// Filters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="booster">Number-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to boost the recommendation rate of some items based on the values of their attributes.
        /// Boosters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="logic">Logic specifies the particular behavior of the recommendation models. You can pick tailored logic for your domain and use case.
        /// See [this section](https://docs.recombee.com/recommendation_logics) for a list of available logics and other details.
        /// The difference between `logic` and `scenario` is that `logic` specifies mainly behavior, while `scenario` specifies the place where recommendations are shown to the users.
        /// Logic can also be set to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="minRelevance">**Expert option:** If the *targetUserId* is provided:  Specifies the threshold of how relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend a number of items equal to *count* at any cost. If there is not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations being appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such case, the system only recommends items of at least the requested relevance and may return less than *count* items when there is not enough data to fulfill it.
        /// </param>
        /// <param name="rotationRate">**Expert option:** If the *targetUserId* is provided: If your users browse the system in real-time, it may easily happen that you wish to offer them recommendations multiple times. Here comes the question: how much should the recommendations change? Should they remain the same, or should they rotate? Recombee API allows you to control this per request in a backward fashion. You may penalize an item for being recommended in the near past. For the specific user, `rotationRate=1` means maximal rotation, `rotationRate=0` means absolutely no rotation. You may also use, for example, `rotationRate=0.2` for only slight rotation of recommended items.
        /// </param>
        /// <param name="rotationTime">**Expert option:** If the *targetUserId* is provided: Taking *rotationRate* into account, specifies how long it takes for an item to recover from the penalization. For example, `rotationTime=7200.0` means that items recommended less than 2 hours ago are penalized.
        /// </param>
        /// <param name="expertSettings">Dictionary of custom options.
        /// </param>
        /// <param name="returnAbGroup">If there is a custom AB-testing running, return the name of the group to which the request belongs.
        /// </param>
        public RecommendItemsToItemSegment (string contextSegmentId, string targetUserId, long count, string scenario = null, bool? cascadeCreate = null, bool? returnProperties = null, string[] includedProperties = null, string filter = null, string booster = null, Logic logic = null, string minRelevance = null, double? rotationRate = null, double? rotationTime = null, Dictionary<string, object> expertSettings = null, bool? returnAbGroup = null): base(HttpMethod.Post, 3000)
        {
            this.contextSegmentId = contextSegmentId;
            this.targetUserId = targetUserId;
            this.count = count;
            this.scenario = scenario;
            this.cascadeCreate = cascadeCreate;
            this.returnProperties = returnProperties;
            this.includedProperties = includedProperties;
            this.filter = filter;
            this.booster = booster;
            this.logic = logic;
            this.minRelevance = minRelevance;
            this.rotationRate = rotationRate;
            this.rotationTime = rotationTime;
            this.expertSettings = expertSettings;
            this.returnAbGroup = returnAbGroup;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/recomms/item-segments/items/";
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
                {"contextSegmentId", this.ContextSegmentId},
                {"targetUserId", this.TargetUserId},
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
