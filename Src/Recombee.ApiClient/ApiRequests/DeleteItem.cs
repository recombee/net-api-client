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
    /// <summary>Delete item</summary>
    /// <remarks>Deletes an item of given `itemId` from the catalog.
    /// If there are any *purchases*, *ratings*, *bookmarks*, *cart additions* or *detail views* of the item present in the database, they will be deleted in cascade as well. Also, if the item is present in some *series*, it will be removed from all the *series* where present.
    /// If an item becomes obsolete/no longer available, it is often meaningful to keep it in the catalog (along with all the interaction data, which are very useful), and only exclude the item from recommendations. In such a case, use [ReQL filter](https://docs.recombee.com/reql.html) instead of deleting the item completely.
    /// </remarks>
    public class DeleteItem : Request
    {
        private readonly string itemId;
        /// <summary>ID of the item to be deleted.</summary>
        public string ItemId
        {
            get {return itemId;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="itemId">ID of the item to be deleted.</param>
        public DeleteItem (string itemId): base(HttpMethod.Delete, 1000)
        {
            this.itemId = itemId;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/items/{0}", ItemId);
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
