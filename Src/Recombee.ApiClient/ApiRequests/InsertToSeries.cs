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
    /// <summary>Insert to Series</summary>
    /// <remarks>Inserts an existing item/series into a series of the given seriesId at a position determined by time.
    /// </remarks>
    public class InsertToSeries : Request
    {
        private readonly string seriesId;
        /// <summary>ID of the series to be inserted into.</summary>
        public string SeriesId
        {
            get {return seriesId;}
        }
        private readonly string itemType;
        /// <summary>`item` iff the regular item from the catalog is to be inserted, `series` iff series is inserted as the item.</summary>
        public string ItemType
        {
            get {return itemType;}
        }
        private readonly string itemId;
        /// <summary>ID of the item iff `itemType` is `item`. ID of the series iff `itemType` is `series`.</summary>
        public string ItemId
        {
            get {return itemId;}
        }
        private readonly double time;
        /// <summary>Time index used for sorting items in the series. According to time, items are sorted within series in ascending order. In the example of TV show episodes, the episode number is a natural choice to be passed as time.</summary>
        public double Time
        {
            get {return time;}
        }
        private readonly bool? cascadeCreate;
        /// <summary>Indicates that any non-existing entity specified within the request should be created (as if corresponding PUT requests were invoked). This concerns both the `seriesId` and the `itemId`. If `cascadeCreate` is set to true, the behavior also depends on the `itemType`. In case of `item`, an item is created, in case of `series` a series + corresponding item with the same ID is created.</summary>
        public bool? CascadeCreate
        {
            get {return cascadeCreate;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="seriesId">ID of the series to be inserted into.</param>
        /// <param name="itemType">`item` iff the regular item from the catalog is to be inserted, `series` iff series is inserted as the item.</param>
        /// <param name="itemId">ID of the item iff `itemType` is `item`. ID of the series iff `itemType` is `series`.</param>
        /// <param name="time">Time index used for sorting items in the series. According to time, items are sorted within series in ascending order. In the example of TV show episodes, the episode number is a natural choice to be passed as time.</param>
        /// <param name="cascadeCreate">Indicates that any non-existing entity specified within the request should be created (as if corresponding PUT requests were invoked). This concerns both the `seriesId` and the `itemId`. If `cascadeCreate` is set to true, the behavior also depends on the `itemType`. In case of `item`, an item is created, in case of `series` a series + corresponding item with the same ID is created.</param>
        public InsertToSeries (string seriesId, string itemType, string itemId, double time, bool? cascadeCreate = null): base(HttpMethod.Post, 3000)
        {
            this.seriesId = seriesId;
            this.itemType = itemType;
            this.itemId = itemId;
            this.time = time;
            this.cascadeCreate = cascadeCreate;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/series/{0}/items/", SeriesId);
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
                {"itemType", this.ItemType},
                {"itemId", this.ItemId},
                {"time", this.Time}
            };
            if (this.CascadeCreate.HasValue)
                parameters["cascadeCreate"] = this.CascadeCreate.Value;
            return parameters;
        }
    
    }
}
