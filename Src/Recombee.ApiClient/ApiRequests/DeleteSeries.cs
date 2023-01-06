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
    /// <summary>Delete Series</summary>
    /// <remarks>Deletes the series of the given `seriesId` from the database.
    /// Deleting a series will only delete assignment of items to it, not the items themselves!
    /// </remarks>
    public class DeleteSeries : Request
    {
        private readonly string seriesId;
        /// <summary>ID of the series to be deleted.</summary>
        public string SeriesId
        {
            get {return seriesId;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="seriesId">ID of the series to be deleted.</param>
        public DeleteSeries (string seriesId): base(HttpMethod.Delete, 1000)
        {
            this.seriesId = seriesId;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/series/{0}", SeriesId);
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
        
            };
            return parameters;
        }
    
    }
}
