/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using Recombee.ApiClient.Util;


namespace Recombee.ApiClient.ApiRequests
{
    /// <summary>User based recommendation</summary>
    /// <deprecated>Deprecated since version 2.0.0. Use RecommendItemsToUser request instead.</deprecated>
    /// <remarks>Based on user's past interactions (purchases, ratings, etc.) with the items, recommends top-N items that are most likely to be of high value for a given user.
    /// It is also possible to use POST HTTP method (for example in case of very long ReQL filter) - query parameters then become body parameters.
    /// </remarks>
    [Obsolete("Deprecated since version 2.0.0. Use RecommendItemsToUser request instead.", false)]
    public class UserBasedRecommendation : Request
    {
        private readonly string userId;
        /// <summary>ID of the user for which the personalized recommendations are to be generated.</summary>
        public string UserId
        {
            get {return userId;}
        }
        private readonly long count;
        /// <summary>Number of items to be recommended (N for the top-N recommendation).</summary>
        public long Count
        {
            get {return count;}
        }
        private readonly string filter;
        /// <summary>Boolean-returning [ReQL](https://docs.recombee.com/reql.html) expression which allows you to filter recommended items based on the values of their attributes.</summary>
        public string Filter
        {
            get {return filter;}
        }
        private readonly string booster;
        /// <summary>Number-returning [ReQL](https://docs.recombee.com/reql.html) expression which allows you to boost recommendation rate of some items based on the values of their attributes.</summary>
        public string Booster
        {
            get {return booster;}
        }
        private readonly bool? allowNonexistent;
        /// <summary>If the user does not exist in the database, returns a list of non-personalized recommendations instead of causing HTTP 404 error. It doesn't create the user in the database.</summary>
        public bool? AllowNonexistent
        {
            get {return allowNonexistent;}
        }
        private readonly bool? cascadeCreate;
        /// <summary>If the user does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows for example rotations in the following recommendations for that user, as the user will be already known to the system.</summary>
        public bool? CascadeCreate
        {
            get {return cascadeCreate;}
        }
        private readonly string scenario;
        /// <summary>Scenario defines a particular application of recommendations. It can be for example "homepage", "cart" or "emailing". You can see each scenario in the UI separately, so you can check how well each application performs. The AI which optimizes models in order to get the best results may optimize different scenarios separately, or even use different models in each of the scenarios.</summary>
        public string Scenario
        {
            get {return scenario;}
        }
        private readonly bool? returnProperties;
        /// <summary>With `returnProperties=true`, property values of the recommended items are returned along with their IDs in a JSON dictionary. The acquired property values can be used for easy displaying of the recommended items to the user. 
        /// Example response:
        /// ```
        ///   [
        ///     {
        ///       "itemId": "tv-178",
        ///       "description": "4K TV with 3D feature",
        ///       "categories":   ["Electronics", "Televisions"],
        ///       "price": 342,
        ///       "url": "myshop.com/tv-178"
        ///     },
        ///     {
        ///       "itemId": "mixer-42",
        ///       "description": "Stainless Steel Mixer",
        ///       "categories":   ["Home & Kitchen"],
        ///       "price": 39,
        ///       "url": "myshop.com/mixer-42"
        ///     }
        ///   ]
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
        ///   [
        ///     {
        ///       "itemId": "tv-178",
        ///       "description": "4K TV with 3D feature",
        ///       "price": 342
        ///     },
        ///     {
        ///       "itemId": "mixer-42",
        ///       "description": "Stainless Steel Mixer",
        ///       "price": 39
        ///     }
        ///   ]
        /// ```
        /// </summary>
        public string[] IncludedProperties
        {
            get {return includedProperties;}
        }
        private readonly double? diversity;
        /// <summary>**Expert option** Real number from [0.0, 1.0] which determines how much mutually dissimilar should the recommended items be. The default value is 0.0, i.e., no diversification. Value 1.0 means maximal diversification.
        /// </summary>
        public double? Diversity
        {
            get {return diversity;}
        }
        private readonly string minRelevance;
        /// <summary>**Expert option** Specifies the threshold of how much relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend number of items equal to *count* at any cost. If there are not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations to be appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such case, the system only recommends items of at least the requested qualit, and may return less than *count* items when there is not enough data to fulfill it.
        /// </summary>
        public string MinRelevance
        {
            get {return minRelevance;}
        }
        private readonly double? rotationRate;
        /// <summary>**Expert option** If your users browse the system in real-time, it may easily happen that you wish to offer them recommendations multiple times. Here comes the question: how much should the recommendations change? Should they remain the same, or should they rotate? Recombee API allows you to control this per-request in backward fashion. You may penalize an item for being recommended in the near past. For the specific user, `rotationRate=1` means maximal rotation, `rotationRate=0` means absolutely no rotation. You may also use, for example `rotationRate=0.2` for only slight rotation of recommended items.
        /// </summary>
        public double? RotationRate
        {
            get {return rotationRate;}
        }
        private readonly double? rotationTime;
        /// <summary>**Expert option** Taking *rotationRate* into account, specifies how long time it takes to an item to recover from the penalization. For example, `rotationTime=7200.0` means that items recommended less than 2 hours ago are penalized.
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
    
        /// <summary>Construct the request</summary>
        /// <param name="userId">ID of the user for which the personalized recommendations are to be generated.</param>
        /// <param name="count">Number of items to be recommended (N for the top-N recommendation).</param>
        /// <param name="filter">Boolean-returning [ReQL](https://docs.recombee.com/reql.html) expression which allows you to filter recommended items based on the values of their attributes.</param>
        /// <param name="booster">Number-returning [ReQL](https://docs.recombee.com/reql.html) expression which allows you to boost recommendation rate of some items based on the values of their attributes.</param>
        /// <param name="allowNonexistent">If the user does not exist in the database, returns a list of non-personalized recommendations instead of causing HTTP 404 error. It doesn't create the user in the database.</param>
        /// <param name="cascadeCreate">If the user does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows for example rotations in the following recommendations for that user, as the user will be already known to the system.</param>
        /// <param name="scenario">Scenario defines a particular application of recommendations. It can be for example "homepage", "cart" or "emailing". You can see each scenario in the UI separately, so you can check how well each application performs. The AI which optimizes models in order to get the best results may optimize different scenarios separately, or even use different models in each of the scenarios.</param>
        /// <param name="returnProperties">With `returnProperties=true`, property values of the recommended items are returned along with their IDs in a JSON dictionary. The acquired property values can be used for easy displaying of the recommended items to the user. 
        /// Example response:
        /// ```
        ///   [
        ///     {
        ///       "itemId": "tv-178",
        ///       "description": "4K TV with 3D feature",
        ///       "categories":   ["Electronics", "Televisions"],
        ///       "price": 342,
        ///       "url": "myshop.com/tv-178"
        ///     },
        ///     {
        ///       "itemId": "mixer-42",
        ///       "description": "Stainless Steel Mixer",
        ///       "categories":   ["Home & Kitchen"],
        ///       "price": 39,
        ///       "url": "myshop.com/mixer-42"
        ///     }
        ///   ]
        /// ```
        /// </param>
        /// <param name="includedProperties">Allows to specify, which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list. 
        /// Example response for `includedProperties=description,price`:
        /// ```
        ///   [
        ///     {
        ///       "itemId": "tv-178",
        ///       "description": "4K TV with 3D feature",
        ///       "price": 342
        ///     },
        ///     {
        ///       "itemId": "mixer-42",
        ///       "description": "Stainless Steel Mixer",
        ///       "price": 39
        ///     }
        ///   ]
        /// ```
        /// </param>
        /// <param name="diversity">**Expert option** Real number from [0.0, 1.0] which determines how much mutually dissimilar should the recommended items be. The default value is 0.0, i.e., no diversification. Value 1.0 means maximal diversification.
        /// </param>
        /// <param name="minRelevance">**Expert option** Specifies the threshold of how much relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend number of items equal to *count* at any cost. If there are not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations to be appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such case, the system only recommends items of at least the requested qualit, and may return less than *count* items when there is not enough data to fulfill it.
        /// </param>
        /// <param name="rotationRate">**Expert option** If your users browse the system in real-time, it may easily happen that you wish to offer them recommendations multiple times. Here comes the question: how much should the recommendations change? Should they remain the same, or should they rotate? Recombee API allows you to control this per-request in backward fashion. You may penalize an item for being recommended in the near past. For the specific user, `rotationRate=1` means maximal rotation, `rotationRate=0` means absolutely no rotation. You may also use, for example `rotationRate=0.2` for only slight rotation of recommended items.
        /// </param>
        /// <param name="rotationTime">**Expert option** Taking *rotationRate* into account, specifies how long time it takes to an item to recover from the penalization. For example, `rotationTime=7200.0` means that items recommended less than 2 hours ago are penalized.
        /// </param>
        /// <param name="expertSettings">Dictionary of custom options.
        /// </param>
        public UserBasedRecommendation (string userId, long count, string filter = null, string booster = null, bool? allowNonexistent = null, bool? cascadeCreate = null, string scenario = null, bool? returnProperties = null, string[] includedProperties = null, double? diversity = null, string minRelevance = null, double? rotationRate = null, double? rotationTime = null, Dictionary<string, object> expertSettings = null): base(HttpMethod.Post, 3000)
        {
            this.userId = userId;
            this.count = count;
            this.filter = filter;
            this.booster = booster;
            this.allowNonexistent = allowNonexistent;
            this.cascadeCreate = cascadeCreate;
            this.scenario = scenario;
            this.returnProperties = returnProperties;
            this.includedProperties = includedProperties;
            this.diversity = diversity;
            this.minRelevance = minRelevance;
            this.rotationRate = rotationRate;
            this.rotationTime = rotationTime;
            this.expertSettings = expertSettings;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/users/{0}/recomms/", UserId);
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
                {"count", Count}
            };
            if (Filter != null)
                parameters["filter"] = Filter;
            if (Booster != null)
                parameters["booster"] = Booster;
            if (AllowNonexistent.HasValue)
                parameters["allowNonexistent"] = AllowNonexistent.Value;
            if (CascadeCreate.HasValue)
                parameters["cascadeCreate"] = CascadeCreate.Value;
            if (Scenario != null)
                parameters["scenario"] = Scenario;
            if (ReturnProperties.HasValue)
                parameters["returnProperties"] = ReturnProperties.Value;
            if (IncludedProperties != null)
                parameters["includedProperties"] = string.Join(",", IncludedProperties);
            if (Diversity.HasValue)
                parameters["diversity"] = Diversity.Value;
            if (MinRelevance != null)
                parameters["minRelevance"] = MinRelevance;
            if (RotationRate.HasValue)
                parameters["rotationRate"] = RotationRate.Value;
            if (RotationTime.HasValue)
                parameters["rotationTime"] = RotationTime.Value;
            if (ExpertSettings != null)
                parameters["expertSettings"] = ExpertSettings;
            return parameters;
        }
    
    }
}
