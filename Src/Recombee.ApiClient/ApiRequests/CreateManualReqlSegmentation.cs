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
    /// <summary>Create Manual ReQL Segmentation</summary>
    /// <remarks>Segment the items using multiple [ReQL](https://docs.recombee.com/reql.html) filters.
    /// Use the Add Manual ReQL Items Segment endpoint to create the individual segments.
    /// </remarks>
    public class CreateManualReqlSegmentation : Request
    {
        private readonly string segmentationId;
        /// <summary>ID of the newly created Segmentation</summary>
        public string SegmentationId
        {
            get {return segmentationId;}
        }
        private readonly string sourceType;
        /// <summary>What type of data should be segmented. Currently only `items` are supported.
        /// </summary>
        public string SourceType
        {
            get {return sourceType;}
        }
        private readonly string title;
        /// <summary>Human-readable name that is shown in the Recombee Admin UI.
        /// </summary>
        public string Title
        {
            get {return title;}
        }
        private readonly string description;
        /// <summary>Description that is shown in the Recombee Admin UI.
        /// </summary>
        public string Description
        {
            get {return description;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="segmentationId">ID of the newly created Segmentation</param>
        /// <param name="sourceType">What type of data should be segmented. Currently only `items` are supported.
        /// </param>
        /// <param name="title">Human-readable name that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="description">Description that is shown in the Recombee Admin UI.
        /// </param>
        public CreateManualReqlSegmentation (string segmentationId, string sourceType, string title = null, string description = null): base(HttpMethod.Put, 10000)
        {
            this.segmentationId = segmentationId;
            this.sourceType = sourceType;
            this.title = title;
            this.description = description;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/segmentations/manual-reql/{0}", SegmentationId);
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
                {"sourceType", this.SourceType}
            };
            if (this.Title != null)
                parameters["title"] = this.Title;
            if (this.Description != null)
                parameters["description"] = this.Description;
            return parameters;
        }
    
    }
}
