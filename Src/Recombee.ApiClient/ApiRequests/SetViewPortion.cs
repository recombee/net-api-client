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
    /// <summary>Set View Portion</summary>
    /// <remarks>Sets viewed portion of an item (for example a video or article) by a user (at a session).
    /// If you send a new request with the same (`userId`, `itemId`, `sessionId`), the portion gets updated.
    /// </remarks>
    public class SetViewPortion : Request
    {
        private readonly string userId;
        /// <summary>User who viewed a portion of the item</summary>
        public string UserId
        {
            get {return userId;}
        }
        private readonly string itemId;
        /// <summary>Viewed item</summary>
        public string ItemId
        {
            get {return itemId;}
        }
        private readonly double portion;
        /// <summary>Viewed portion of the item (number between 0.0 (viewed nothing) and 1.0 (viewed full item) ). It should be the actual viewed part of the item, no matter the seeking. For example, if the user seeked immediately to half of the item and then viewed 10% of the item, the `portion` should still be `0.1`.</summary>
        public double Portion
        {
            get {return portion;}
        }
        private readonly string sessionId;
        /// <summary>ID of the session in which the user viewed the item. Default is `null` (`None`, `nil`, `NULL` etc., depending on the language).</summary>
        public string SessionId
        {
            get {return sessionId;}
        }
        private readonly DateTime? timestamp;
        /// <summary>UTC timestamp of the rating as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</summary>
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
        /// <summary>If this view portion is based on a recommendation request, `recommId` is the id of the clicked recommendation.</summary>
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
        /// <param name="userId">User who viewed a portion of the item</param>
        /// <param name="itemId">Viewed item</param>
        /// <param name="portion">Viewed portion of the item (number between 0.0 (viewed nothing) and 1.0 (viewed full item) ). It should be the actual viewed part of the item, no matter the seeking. For example, if the user seeked immediately to half of the item and then viewed 10% of the item, the `portion` should still be `0.1`.</param>
        /// <param name="sessionId">ID of the session in which the user viewed the item. Default is `null` (`None`, `nil`, `NULL` etc., depending on the language).</param>
        /// <param name="timestamp">UTC timestamp of the rating as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</param>
        /// <param name="cascadeCreate">Sets whether the given user/item should be created if not present in the database.</param>
        /// <param name="recommId">If this view portion is based on a recommendation request, `recommId` is the id of the clicked recommendation.</param>
        /// <param name="additionalData">A dictionary of additional data for the interaction.</param>
        public SetViewPortion (string userId, string itemId, double portion, string sessionId = null, DateTime? timestamp = null, bool? cascadeCreate = null, string recommId = null, Dictionary<string, object> additionalData = null): base(HttpMethod.Post, 1000)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.portion = portion;
            this.sessionId = sessionId;
            this.timestamp = timestamp;
            this.cascadeCreate = cascadeCreate;
            this.recommId = recommId;
            this.additionalData = additionalData;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/viewportions/";
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
                {"itemId", this.ItemId},
                {"portion", this.Portion}
            };
            if (this.SessionId != null)
                parameters["sessionId"] = this.SessionId;
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
