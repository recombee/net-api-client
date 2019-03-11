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
    /// <summary>Remove from group</summary>
    /// <remarks>Removes an existing group item from the group.</remarks>
    public class RemoveFromGroup : Request
    {
        private readonly string groupId;
        /// <summary>ID of the group from which a group item is to be removed.</summary>
        public string GroupId
        {
            get {return groupId;}
        }
        private readonly string itemType;
        /// <summary>Type of the item to be removed.</summary>
        public string ItemType
        {
            get {return itemType;}
        }
        private readonly string itemId;
        /// <summary>ID of the item iff `itemType` is `item`. ID of the group iff `itemType` is `group`.</summary>
        public string ItemId
        {
            get {return itemId;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="groupId">ID of the group from which a group item is to be removed.</param>
        /// <param name="itemType">Type of the item to be removed.</param>
        /// <param name="itemId">ID of the item iff `itemType` is `item`. ID of the group iff `itemType` is `group`.</param>
        public RemoveFromGroup (string groupId, string itemType, string itemId): base(HttpMethod.Delete, 1000)
        {
            this.groupId = groupId;
            this.itemType = itemType;
            this.itemId = itemId;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/groups/{0}/items/", GroupId);
        }
    
        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> QueryParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
                {"itemType", this.ItemType},
                {"itemId", this.ItemId}
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
