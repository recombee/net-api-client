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
    /// <summary>Add Manual ReQL Segment</summary>
    /// <remarks>Adds a new Segment into a Manual ReQL Segmentation.
    /// The new Segment is defined by a [ReQL](https://docs.recombee.com/reql.html) filter that returns `true` for an item in case that this item belongs to the segment.
    /// </remarks>
    public class AddManualReqlSegment : Request
    {
        private readonly string segmentationId;
        /// <summary>ID of the Segmentation to which the new Segment should be added</summary>
        public string SegmentationId
        {
            get {return segmentationId;}
        }
        private readonly string segmentId;
        /// <summary>ID of the newly created Segment</summary>
        public string SegmentId
        {
            get {return segmentId;}
        }
        private readonly string filter;
        /// <summary>ReQL filter that returns `true` for items that belong to this Segment. Otherwise returns `false`.
        /// </summary>
        public string Filter
        {
            get {return filter;}
        }
        private readonly string title;
        /// <summary>Human-readable name of the Segment that is shown in the Recombee Admin UI.
        /// </summary>
        public string Title
        {
            get {return title;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="segmentationId">ID of the Segmentation to which the new Segment should be added</param>
        /// <param name="segmentId">ID of the newly created Segment</param>
        /// <param name="filter">ReQL filter that returns `true` for items that belong to this Segment. Otherwise returns `false`.
        /// </param>
        /// <param name="title">Human-readable name of the Segment that is shown in the Recombee Admin UI.
        /// </param>
        public AddManualReqlSegment (string segmentationId, string segmentId, string filter, string title = null): base(HttpMethod.Put, 10000)
        {
            this.segmentationId = segmentationId;
            this.segmentId = segmentId;
            this.filter = filter;
            this.title = title;
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
                {"filter", this.Filter}
            };
            if (this.Title != null)
                parameters["title"] = this.Title;
            return parameters;
        }
    
    }
}
