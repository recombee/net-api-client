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
    /// <summary>Update More Items</summary>
    /// <remarks>Updates (some) property values of all the items that pass the filter.
    /// Example: *Setting all the items that are older than a week as unavailable*
    ///   ```
    ///     {
    ///       "filter": "'releaseDate' < now() - 7*24*3600",
    ///       "changes": {"available": false}
    ///     }
    ///   ```
    /// </remarks>
    public class UpdateMoreItems : Request
    {
        private readonly string filter;
        /// <summary>A [ReQL](https://docs.recombee.com/reql.html) expression, which returns `true` for the items that shall be updated.</summary>
        public string Filter
        {
            get {return filter;}
        }
        private readonly Dictionary<string, object> changes;
        /// <summary>A dictionary where the keys are properties that shall be updated.</summary>
        public Dictionary<string, object> Changes
        {
            get {return changes;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="filter">A [ReQL](https://docs.recombee.com/reql.html) expression, which returns `true` for the items that shall be updated.</param>
        /// <param name="changes">A dictionary where the keys are properties that shall be updated.</param>
        public UpdateMoreItems (string filter, Dictionary<string, object> changes): base(HttpMethod.Post, 100000)
        {
            this.filter = filter;
            this.changes = changes;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/more-items/";
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
                {"filter", this.Filter},
                {"changes", this.Changes}
            };
            return parameters;
        }
    
    }
}
