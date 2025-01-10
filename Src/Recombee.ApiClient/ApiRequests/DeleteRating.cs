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
    /// <summary>Delete Rating</summary>
    /// <remarks>Deletes an existing rating specified by (`userId`, `itemId`, `timestamp`) from the database or all the ratings with the given `userId` and `itemId` if `timestamp` is omitted.
    /// </remarks>
    public class DeleteRating : Request
    {
        private readonly string userId;
        /// <summary>ID of the user who rated the item.</summary>
        public string UserId
        {
            get {return userId;}
        }
        private readonly string itemId;
        /// <summary>ID of the item which was rated.</summary>
        public string ItemId
        {
            get {return itemId;}
        }
        private readonly DateTime? timestamp;
        /// <summary>Unix timestamp of the rating. If the `timestamp` is omitted, then all the ratings with the given `userId` and `itemId` are deleted.</summary>
        public DateTime? Timestamp
        {
            get {return timestamp;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="userId">ID of the user who rated the item.</param>
        /// <param name="itemId">ID of the item which was rated.</param>
        /// <param name="timestamp">Unix timestamp of the rating. If the `timestamp` is omitted, then all the ratings with the given `userId` and `itemId` are deleted.</param>
        public DeleteRating (string userId, string itemId, DateTime? timestamp = null): base(HttpMethod.Delete, 3000)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.timestamp = timestamp;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/ratings/";
        }
    
        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> QueryParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
                {"userId", this.UserId},
                {"itemId", this.ItemId}
            };
            if (this.Timestamp.HasValue)
                parameters["timestamp"] = ConvertToUnixTimestamp(this.Timestamp.Value);
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
