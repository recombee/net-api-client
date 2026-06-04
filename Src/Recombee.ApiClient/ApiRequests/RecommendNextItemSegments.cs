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
    /// <summary>Recommend Next Item Segments</summary>
    /// <remarks>Returns [Item Segments](https://docs.recombee.com/segmentations) to be shown as the next recommendations when a user scrolls (e.g., within a carousel or feed of Item Segments such as brands, artists, topics, or categories).
    /// The request requires the `recommId` of a base recommendation request and the number of Segments to return (`count`).
    /// The base request can be one of:
    ///   - [Recommend Item Segments to Item](https://docs.recombee.com/api#recommend-item-segments-to-item)
    ///   - [Recommend Item Segments to User](https://docs.recombee.com/api#recommend-item-segments-to-user)
    ///   - [Recommend Item Segments to Item Segment](https://docs.recombee.com/api#recommend-item-segments-to-item-segment)
    ///   - [Search Item Segments](https://docs.recombee.com/api#search-item-segments)
    /// All other parameters are inherited from the base request associated with the provided `recommId`.
    /// This endpoint can be called multiple times for a single `recommId`. Each call returns different Item Segments that have not been recommended in previous calls.
    /// The number of calls made so far is returned in the `numberNextRecommsCalls` field.
    /// Requests can be made up to 30 minutes after the base request or the most recent Recommend Next Item Segments call.
    /// For billing purposes, each call to this endpoint is counted as a separate recommendation request.
    /// </remarks>
    public class RecommendNextItemSegments : Request
    {
        private readonly string recommId;
        /// <summary>ID of the base recommendation request for which next recommendations should be returned</summary>
        public string RecommId
        {
            get {return recommId;}
        }
        private readonly long count;
        /// <summary>Number of item segments to be recommended
        /// </summary>
        public long Count
        {
            get {return count;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="recommId">ID of the base recommendation request for which next recommendations should be returned</param>
        /// <param name="count">Number of item segments to be recommended
        /// </param>
        public RecommendNextItemSegments (string recommId, long count): base(HttpMethod.Post, 3000)
        {
            this.recommId = recommId;
            this.count = count;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/recomms/next/item-segments/{0}", RecommId);
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
            return parameters;
        }
    
    }
}
