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
    /// <summary>Add item</summary>
    /// <remarks>Adds new item of given `itemId` to the items catalog.
    /// All the item properties for the newly created items are set null.
    /// </remarks>
    public class AddItem : Request
    {
        private readonly string itemId;
        /// <summary>ID of the item to be created.</summary>
        public string ItemId
        {
            get {return itemId;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="itemId">ID of the item to be created.</param>
        public AddItem (string itemId): base(HttpMethod.Put, 1000)
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
