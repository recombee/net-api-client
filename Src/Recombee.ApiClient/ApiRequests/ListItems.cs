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
    /// <summary>List items</summary>
    /// <remarks>Gets a list of IDs of items currently present in the catalog.</remarks>
    public class ListItems : Request
    {
        private readonly string filter;
        /// <summary>Boolean-returning [ReQL](https://docs.recombee.com/reql.html) expression, which allows you to filter items to be listed. Only the items for which the expression is *true* will be returned.</summary>
        public string Filter
        {
            get {return filter;}
        }
        private readonly long? count;
        /// <summary>The number of items to be listed.</summary>
        public long? Count
        {
            get {return count;}
        }
        private readonly long? offset;
        /// <summary>Specifies the number of items to skip (ordered by `itemId`).</summary>
        public long? Offset
        {
            get {return offset;}
        }
        private readonly bool? returnProperties;
        /// <summary>With `returnProperties=true`, property values of the listed items are returned along with their IDs in a JSON dictionary. 
        /// Example response:
        /// ```
        ///   [
        ///     {
        ///       "itemId": "tv-178",
        ///       "description": "4K TV with 3D feature",
        ///       "categories":   ["Electronics", "Televisions"],
        ///       "price": 342,
        ///       "url": "myshop.com/tv-178"
        ///     },
        ///     {
        ///       "itemId": "mixer-42",
        ///       "description": "Stainless Steel Mixer",
        ///       "categories":   ["Home & Kitchen"],
        ///       "price": 39,
        ///       "url": "myshop.com/mixer-42"
        ///     }
        ///   ]
        /// ```
        /// </summary>
        public bool? ReturnProperties
        {
            get {return returnProperties;}
        }
        private readonly string[] includedProperties;
        /// <summary>Allows to specify, which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list. 
        /// Example response for `includedProperties=description,price`:
        /// ```
        ///   [
        ///     {
        ///       "itemId": "tv-178",
        ///       "description": "4K TV with 3D feature",
        ///       "price": 342
        ///     },
        ///     {
        ///       "itemId": "mixer-42",
        ///       "description": "Stainless Steel Mixer",
        ///       "price": 39
        ///     }
        ///   ]
        /// ```
        /// </summary>
        public string[] IncludedProperties
        {
            get {return includedProperties;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="filter">Boolean-returning [ReQL](https://docs.recombee.com/reql.html) expression, which allows you to filter items to be listed. Only the items for which the expression is *true* will be returned.</param>
        /// <param name="count">The number of items to be listed.</param>
        /// <param name="offset">Specifies the number of items to skip (ordered by `itemId`).</param>
        /// <param name="returnProperties">With `returnProperties=true`, property values of the listed items are returned along with their IDs in a JSON dictionary. 
        /// Example response:
        /// ```
        ///   [
        ///     {
        ///       "itemId": "tv-178",
        ///       "description": "4K TV with 3D feature",
        ///       "categories":   ["Electronics", "Televisions"],
        ///       "price": 342,
        ///       "url": "myshop.com/tv-178"
        ///     },
        ///     {
        ///       "itemId": "mixer-42",
        ///       "description": "Stainless Steel Mixer",
        ///       "categories":   ["Home & Kitchen"],
        ///       "price": 39,
        ///       "url": "myshop.com/mixer-42"
        ///     }
        ///   ]
        /// ```
        /// </param>
        /// <param name="includedProperties">Allows to specify, which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list. 
        /// Example response for `includedProperties=description,price`:
        /// ```
        ///   [
        ///     {
        ///       "itemId": "tv-178",
        ///       "description": "4K TV with 3D feature",
        ///       "price": 342
        ///     },
        ///     {
        ///       "itemId": "mixer-42",
        ///       "description": "Stainless Steel Mixer",
        ///       "price": 39
        ///     }
        ///   ]
        /// ```
        /// </param>
        public ListItems (string filter = null, long? count = null, long? offset = null, bool? returnProperties = null, string[] includedProperties = null): base(HttpMethod.Get, 100000)
        {
            this.filter = filter;
            this.count = count;
            this.offset = offset;
            this.returnProperties = returnProperties;
            this.includedProperties = includedProperties;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/items/list/";
        }
    
        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> QueryParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
        
            };
            if (this.Filter != null)
                parameters["filter"] = this.Filter;
            if (this.Count.HasValue)
                parameters["count"] = this.Count.Value;
            if (this.Offset.HasValue)
                parameters["offset"] = this.Offset.Value;
            if (this.ReturnProperties.HasValue)
                parameters["returnProperties"] = this.ReturnProperties.Value;
            if (this.IncludedProperties != null)
                parameters["includedProperties"] = string.Join(",", this.IncludedProperties);
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
