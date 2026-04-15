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
    /// <summary>Recommend Next Item segments</summary>
    /// <remarks>Returns Item segments that shall be shown to a user as next recommendations when the user e.g. scrolls the page down (*infinite scroll*) or goes to the next page.
    /// It accepts `recommId` of a base recommendation request (e.g., request from the first page) and the number of segments that shall be returned (`count`).
    /// The base request can be one of:
    ///   - [Recommend Item Segments to Item](https://docs.recombee.com/api#recommend-item-segments-to-item)
    ///   - [Recommend Item Segments to User](https://docs.recombee.com/api#recommend-item-segments-to-user)
    ///   - [Recommend Item Segments to Item Segment](https://docs.recombee.com/api#recommend-item-segments-to-item-segment)
    ///   - [Search Item Segments](https://docs.recombee.com/api#search-item-segments)
    /// All the other parameters are inherited from the base request.
    /// *Recommend next Item segments* can be called many times for a single `recommId` and each call returns different (previously not recommended) segments.
    /// The number of *Recommend next Item segments* calls performed so far is returned in the `numberNextRecommsCalls` field.
    /// *Recommend next Item segments* can be requested up to 30 minutes after the base request or a previous *Recommend next Item segments* call.
    /// For billing purposes, each call to *Recommend next Item segments* is counted as a separate recommendation request.
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
