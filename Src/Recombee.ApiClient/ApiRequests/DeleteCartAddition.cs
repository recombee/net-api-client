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
    /// <summary>Delete Cart Addition</summary>
    /// <remarks>Deletes an existing cart addition uniquely specified by `userId`, `itemId`, and `timestamp` or all the cart additions with the given `userId` and `itemId` if `timestamp` is omitted.
    /// </remarks>
    public class DeleteCartAddition : Request
    {
        private readonly string userId;
        /// <summary>ID of the user who made the cart addition.</summary>
        public string UserId
        {
            get {return userId;}
        }
        private readonly string itemId;
        /// <summary>ID of the item which was added to the cart.</summary>
        public string ItemId
        {
            get {return itemId;}
        }
        private readonly DateTime? timestamp;
        /// <summary>Unix timestamp of the cart addition. If the `timestamp` is omitted, then all the cart additions with the given `userId` and `itemId` are deleted.</summary>
        public DateTime? Timestamp
        {
            get {return timestamp;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="userId">ID of the user who made the cart addition.</param>
        /// <param name="itemId">ID of the item which was added to the cart.</param>
        /// <param name="timestamp">Unix timestamp of the cart addition. If the `timestamp` is omitted, then all the cart additions with the given `userId` and `itemId` are deleted.</param>
        public DeleteCartAddition (string userId, string itemId, DateTime? timestamp = null): base(HttpMethod.Delete, 3000)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.timestamp = timestamp;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/cartadditions/";
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
