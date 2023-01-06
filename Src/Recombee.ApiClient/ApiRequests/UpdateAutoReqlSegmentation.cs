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
    /// <summary>Update Auto ReQL Segmentation</summary>
    /// <remarks>Update an existing Segmentation.
    /// </remarks>
    public class UpdateAutoReqlSegmentation : Request
    {
        private readonly string segmentationId;
        /// <summary>ID of the updated Segmentation</summary>
        public string SegmentationId
        {
            get {return segmentationId;}
        }
        private readonly string expression;
        /// <summary>ReQL expression that returns for each item a set with IDs of segments to which the item belongs
        /// </summary>
        public string Expression
        {
            get {return expression;}
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
        /// <param name="segmentationId">ID of the updated Segmentation</param>
        /// <param name="expression">ReQL expression that returns for each item a set with IDs of segments to which the item belongs
        /// </param>
        /// <param name="title">Human-readable name that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="description">Description that is shown in the Recombee Admin UI.
        /// </param>
        public UpdateAutoReqlSegmentation (string segmentationId, string expression = null, string title = null, string description = null): base(HttpMethod.Post, 10000)
        {
            this.segmentationId = segmentationId;
            this.expression = expression;
            this.title = title;
            this.description = description;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/segmentations/auto-reql/{0}", SegmentationId);
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
            if (this.Expression != null)
                parameters["expression"] = this.Expression;
            if (this.Title != null)
                parameters["title"] = this.Title;
            if (this.Description != null)
                parameters["description"] = this.Description;
            return parameters;
        }
    
    }
}
