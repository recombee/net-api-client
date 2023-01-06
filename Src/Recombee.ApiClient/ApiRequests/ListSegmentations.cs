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
    /// <summary>List Segmentations</summary>
    /// <remarks>Return all existing items Segmentations.
    /// </remarks>
    public class ListSegmentations : Request
    {
        private readonly string sourceType;
        /// <summary>List Segmentations based on a particular type of data. Currently only `items` are supported.</summary>
        public string SourceType
        {
            get {return sourceType;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="sourceType">List Segmentations based on a particular type of data. Currently only `items` are supported.</param>
        public ListSegmentations (string sourceType): base(HttpMethod.Get, 10000)
        {
            this.sourceType = sourceType;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/segmentations/list/";
        }
    
        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> QueryParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
                {"sourceType", this.SourceType}
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
