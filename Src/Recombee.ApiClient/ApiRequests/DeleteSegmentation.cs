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
    /// <summary>Delete Segmentation</summary>
    /// <remarks>Delete existing Segmentation.
    /// </remarks>
    public class DeleteSegmentation : Request
    {
        private readonly string segmentationId;
        /// <summary>ID of the Segmentation that should be deleted</summary>
        public string SegmentationId
        {
            get {return segmentationId;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="segmentationId">ID of the Segmentation that should be deleted</param>
        public DeleteSegmentation (string segmentationId): base(HttpMethod.Delete, 10000)
        {
            this.segmentationId = segmentationId;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/segmentations/{0}", SegmentationId);
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
