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
    /// <summary>Delete More Items</summary>
    /// <remarks>Deletes all the items that pass the filter.
    /// If an item becomes obsolete/no longer available, it is meaningful to **keep it in the catalog** (along with all the interaction data, which are very useful) and **only exclude the item from recommendations**. In such a case, use [ReQL filter](https://docs.recombee.com/reql.html) instead of deleting the item completely.</remarks>
    public class DeleteMoreItems : Request
    {
        private readonly string filter;
        /// <summary>A [ReQL](https://docs.recombee.com/reql.html) expression, which returns `true` for the items that shall be updated.</summary>
        public string Filter
        {
            get {return filter;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="filter">A [ReQL](https://docs.recombee.com/reql.html) expression, which returns `true` for the items that shall be updated.</param>
        public DeleteMoreItems (string filter): base(HttpMethod.Delete, 1000)
        {
            this.filter = filter;
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
                {"filter", this.Filter}
            };
            return parameters;
        }
    
    }
}
