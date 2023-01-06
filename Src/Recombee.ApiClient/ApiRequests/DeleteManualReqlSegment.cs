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
    /// <summary>Delete Manual ReQL Segment</summary>
    /// <remarks>Delete a Segment from a Manual ReQL Segmentation.
    /// </remarks>
    public class DeleteManualReqlSegment : Request
    {
        private readonly string segmentationId;
        /// <summary>ID of the Segmentation from which the Segment should be deleted</summary>
        public string SegmentationId
        {
            get {return segmentationId;}
        }
        private readonly string segmentId;
        /// <summary>ID of the Segment that should be deleted</summary>
        public string SegmentId
        {
            get {return segmentId;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="segmentationId">ID of the Segmentation from which the Segment should be deleted</param>
        /// <param name="segmentId">ID of the Segment that should be deleted</param>
        public DeleteManualReqlSegment (string segmentationId, string segmentId): base(HttpMethod.Delete, 10000)
        {
            this.segmentationId = segmentationId;
            this.segmentId = segmentId;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/segmentations/manual-reql/{0}/segments/{1}", SegmentationId, SegmentId);
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
