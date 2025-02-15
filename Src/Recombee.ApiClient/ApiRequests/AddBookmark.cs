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
    /// <summary>Add Bookmark</summary>
    /// <remarks>Adds a bookmark of the given item made by the given user.
    /// </remarks>
    public class AddBookmark : Request
    {
        private readonly string userId;
        /// <summary>User who bookmarked the item</summary>
        public string UserId
        {
            get {return userId;}
        }
        private readonly string itemId;
        /// <summary>Bookmarked item</summary>
        public string ItemId
        {
            get {return itemId;}
        }
        private readonly DateTime? timestamp;
        /// <summary>UTC timestamp of the bookmark as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</summary>
        public DateTime? Timestamp
        {
            get {return timestamp;}
        }
        private readonly bool? cascadeCreate;
        /// <summary>Sets whether the given user/item should be created if not present in the database.</summary>
        public bool? CascadeCreate
        {
            get {return cascadeCreate;}
        }
        private readonly string recommId;
        /// <summary>If this bookmark is based on a recommendation request, `recommId` is the id of the clicked recommendation.</summary>
        public string RecommId
        {
            get {return recommId;}
        }
        private readonly Dictionary<string, object> additionalData;
        /// <summary>A dictionary of additional data for the interaction.</summary>
        public Dictionary<string, object> AdditionalData
        {
            get {return additionalData;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="userId">User who bookmarked the item</param>
        /// <param name="itemId">Bookmarked item</param>
        /// <param name="timestamp">UTC timestamp of the bookmark as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</param>
        /// <param name="cascadeCreate">Sets whether the given user/item should be created if not present in the database.</param>
        /// <param name="recommId">If this bookmark is based on a recommendation request, `recommId` is the id of the clicked recommendation.</param>
        /// <param name="additionalData">A dictionary of additional data for the interaction.</param>
        public AddBookmark (string userId, string itemId, DateTime? timestamp = null, bool? cascadeCreate = null, string recommId = null, Dictionary<string, object> additionalData = null): base(HttpMethod.Post, 3000)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.timestamp = timestamp;
            this.cascadeCreate = cascadeCreate;
            this.recommId = recommId;
            this.additionalData = additionalData;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/bookmarks/";
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
                {"userId", this.UserId},
                {"itemId", this.ItemId}
            };
            if (this.Timestamp.HasValue)
                parameters["timestamp"] = ConvertToUnixTimestamp(this.Timestamp.Value);
            if (this.CascadeCreate.HasValue)
                parameters["cascadeCreate"] = this.CascadeCreate.Value;
            if (this.RecommId != null)
                parameters["recommId"] = this.RecommId;
            if (this.AdditionalData != null)
                parameters["additionalData"] = this.AdditionalData;
            return parameters;
        }
    
    }
}
