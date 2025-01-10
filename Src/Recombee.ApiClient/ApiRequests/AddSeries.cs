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
    /// <summary>Add Series</summary>
    /// <remarks>Creates a new series in the database.</remarks>
    public class AddSeries : Request
    {
        private readonly string seriesId;
        /// <summary>ID of the series to be created.</summary>
        public string SeriesId
        {
            get {return seriesId;}
        }
        private readonly bool? cascadeCreate;
        /// <summary>If set to `true`, the item will be created with the same ID as the series. Default is `true`.</summary>
        public bool? CascadeCreate
        {
            get {return cascadeCreate;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="seriesId">ID of the series to be created.</param>
        /// <param name="cascadeCreate">If set to `true`, the item will be created with the same ID as the series. Default is `true`.</param>
        public AddSeries (string seriesId, bool? cascadeCreate = null): base(HttpMethod.Put, 3000)
        {
            this.seriesId = seriesId;
            this.cascadeCreate = cascadeCreate;
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
            if (this.CascadeCreate.HasValue)
                parameters["cascadeCreate"] = this.CascadeCreate.Value;
            return parameters;
        }
    
    }
}
