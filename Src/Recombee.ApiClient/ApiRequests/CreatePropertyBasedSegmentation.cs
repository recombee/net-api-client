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
    /// <summary>Create Property Based Segmentation</summary>
    /// <remarks>Creates a Segmentation that splits the items into segments based on values of a particular item property.
    /// A segment is created for each unique value of the property.
    /// In case of `set` properties, a segment is created for each value in the set. Item belongs to all these segments.
    /// </remarks>
    public class CreatePropertyBasedSegmentation : Request
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
        private readonly string propertyName;
        /// <summary>Name of the property on which the Segmentation should be based
        /// </summary>
        public string PropertyName
        {
            get {return propertyName;}
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
        /// <param name="propertyName">Name of the property on which the Segmentation should be based
        /// </param>
        /// <param name="title">Human-readable name that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="description">Description that is shown in the Recombee Admin UI.
        /// </param>
        public CreatePropertyBasedSegmentation (string segmentationId, string sourceType, string propertyName, string title = null, string description = null): base(HttpMethod.Put, 10000)
        {
            this.segmentationId = segmentationId;
            this.sourceType = sourceType;
            this.propertyName = propertyName;
            this.title = title;
            this.description = description;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/segmentations/property-based/{0}", SegmentationId);
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
                {"sourceType", this.SourceType},
                {"propertyName", this.PropertyName}
            };
            if (this.Title != null)
                parameters["title"] = this.Title;
            if (this.Description != null)
                parameters["description"] = this.Description;
            return parameters;
        }
    
    }
}
