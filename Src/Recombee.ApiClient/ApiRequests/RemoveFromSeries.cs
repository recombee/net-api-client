/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using Recombee.ApiClient.Util;


namespace Recombee.ApiClient.ApiRequests
{
    /// <summary>Remove from series</summary>
    /// <remarks>Removes an existing series item from the series.</remarks>
    public class RemoveFromSeries : Request
    {
        private readonly string seriesId;
        /// <summary>ID of the series from which a series item is to be removed.</summary>
        public string SeriesId
        {
            get {return seriesId;}
        }
        private readonly string itemType;
        /// <summary>Type of the item to be removed.</summary>
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
        /// <summary>Time index of the item to be removed.</summary>
        public double Time
        {
            get {return time;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="seriesId">ID of the series from which a series item is to be removed.</param>
        /// <param name="itemType">Type of the item to be removed.</param>
        /// <param name="itemId">ID of the item iff `itemType` is `item`. ID of the series iff `itemType` is `series`.</param>
        /// <param name="time">Time index of the item to be removed.</param>
        public RemoveFromSeries (string seriesId, string itemType, string itemId, double time): base(HttpMethod.Delete, 1000)
        {
            this.seriesId = seriesId;
            this.itemType = itemType;
            this.itemId = itemId;
            this.time = time;
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
                {"itemType", ItemType},
                {"itemId", ItemId},
                {"time", Time}
            };
            return parameters;
        }
    
        /// <summary>Get body parameters</summary>
        /// <returns>Dictionary containing  values of body parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> BodyParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
        
            };
            return parameters;
        }
    
    }
}
