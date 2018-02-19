/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using Recombee.ApiClient.Util;


namespace Recombee.ApiClient.ApiRequests
{
    /// <summary>Recommend users to item</summary>
    /// <remarks>Recommend users that are likely to be interested in a given item.
    /// It is also possible to use POST HTTP method (for example in case of very long ReQL filter) - query parameters then become body parameters.
    /// </remarks>
    public class RecommendUsersToItem : Request
    {
        private readonly string itemId;
        /// <summary>ID of the item for which the recommendations are to be generated.</summary>
        public string ItemId
        {
            get {return itemId;}
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
        private readonly bool? cascadeCreate;
        /// <summary>If item of given *itemId* doesn't exist in the database, it creates the missing item.</summary>
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
        /// <summary>With `returnProperties=true`, property values of the recommended users are returned along with their IDs in a JSON dictionary. The acquired property values can be used for easy displaying the recommended users. 
        /// Example response:
        /// ```
        ///   {
        ///     "recommId": "039b71dc-b9cc-4645-a84f-62b841eecfce",
        ///     "recomms":
        ///       [
        ///         {
        ///           "id": "user-17",
        ///           "values": {
        ///             "country": "US",
        ///             "sex": "F"
        ///           }
        ///         },
        ///         {
        ///           "id": "user-2",
        ///           "values": {
        ///             "country": "CAN",
        ///             "sex": "M"
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
        /// Example response for `includedProperties=country`:
        /// ```
        ///   {
        ///     "recommId": "b2b355dd-972a-4728-9c6b-2dc229db0678",
        ///     "recomms":
        ///       [
        ///         {
        ///           "id": "user-17",
        ///           "values": {
        ///             "country": "US"
        ///           }
        ///         },
        ///         {
        ///           "id": "user-2",
        ///           "values": {
        ///             "country": "CAN"
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
        private readonly double? diversity;
        /// <summary>**Expert option** Real number from [0.0, 1.0] which determines how much mutually dissimilar should the recommended items be. The default value is 0.0, i.e., no diversification. Value 1.0 means maximal diversification.
        /// </summary>
        public double? Diversity
        {
            get {return diversity;}
        }
        private readonly Dictionary<string, object> expertSettings;
        /// <summary>Dictionary of custom options.
        /// </summary>
        public Dictionary<string, object> ExpertSettings
        {
            get {return expertSettings;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="itemId">ID of the item for which the recommendations are to be generated.</param>
        /// <param name="count">Number of items to be recommended (N for the top-N recommendation).</param>
        /// <param name="filter">Boolean-returning [ReQL](https://docs.recombee.com/reql.html) expression which allows you to filter recommended items based on the values of their attributes.</param>
        /// <param name="booster">Number-returning [ReQL](https://docs.recombee.com/reql.html) expression which allows you to boost recommendation rate of some items based on the values of their attributes.</param>
        /// <param name="cascadeCreate">If item of given *itemId* doesn't exist in the database, it creates the missing item.</param>
        /// <param name="scenario">Scenario defines a particular application of recommendations. It can be for example "homepage", "cart" or "emailing". You can see each scenario in the UI separately, so you can check how well each application performs. The AI which optimizes models in order to get the best results may optimize different scenarios separately, or even use different models in each of the scenarios.</param>
        /// <param name="returnProperties">With `returnProperties=true`, property values of the recommended users are returned along with their IDs in a JSON dictionary. The acquired property values can be used for easy displaying the recommended users. 
        /// Example response:
        /// ```
        ///   {
        ///     "recommId": "039b71dc-b9cc-4645-a84f-62b841eecfce",
        ///     "recomms":
        ///       [
        ///         {
        ///           "id": "user-17",
        ///           "values": {
        ///             "country": "US",
        ///             "sex": "F"
        ///           }
        ///         },
        ///         {
        ///           "id": "user-2",
        ///           "values": {
        ///             "country": "CAN",
        ///             "sex": "M"
        ///           }
        ///         }
        ///       ]
        ///   }
        /// ```
        /// </param>
        /// <param name="includedProperties">Allows to specify, which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list. 
        /// Example response for `includedProperties=country`:
        /// ```
        ///   {
        ///     "recommId": "b2b355dd-972a-4728-9c6b-2dc229db0678",
        ///     "recomms":
        ///       [
        ///         {
        ///           "id": "user-17",
        ///           "values": {
        ///             "country": "US"
        ///           }
        ///         },
        ///         {
        ///           "id": "user-2",
        ///           "values": {
        ///             "country": "CAN"
        ///           }
        ///         }
        ///       ]
        ///   }
        /// ```
        /// </param>
        /// <param name="diversity">**Expert option** Real number from [0.0, 1.0] which determines how much mutually dissimilar should the recommended items be. The default value is 0.0, i.e., no diversification. Value 1.0 means maximal diversification.
        /// </param>
        /// <param name="expertSettings">Dictionary of custom options.
        /// </param>
        public RecommendUsersToItem (string itemId, long count, string filter = null, string booster = null, bool? cascadeCreate = null, string scenario = null, bool? returnProperties = null, string[] includedProperties = null, double? diversity = null, Dictionary<string, object> expertSettings = null): base(HttpMethod.Post, 50000)
        {
            this.itemId = itemId;
            this.count = count;
            this.filter = filter;
            this.booster = booster;
            this.cascadeCreate = cascadeCreate;
            this.scenario = scenario;
            this.returnProperties = returnProperties;
            this.includedProperties = includedProperties;
            this.diversity = diversity;
            this.expertSettings = expertSettings;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/recomms/items/{0}/users/", ItemId);
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
            if (ExpertSettings != null)
                parameters["expertSettings"] = ExpertSettings;
            return parameters;
        }
    
    }
}
