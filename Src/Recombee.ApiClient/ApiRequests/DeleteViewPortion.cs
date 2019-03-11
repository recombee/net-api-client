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
    /// <summary>Delete view portion</summary>
    /// <remarks>Deletes an existing view portion specified by (`userId`, `itemId`, `sessionId`) from the database.
    /// </remarks>
    public class DeleteViewPortion : Request
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
        private readonly string sessionId;
        /// <summary>Identifier of a session.</summary>
        public string SessionId
        {
            get {return sessionId;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="userId">ID of the user who rated the item.</param>
        /// <param name="itemId">ID of the item which was rated.</param>
        /// <param name="sessionId">Identifier of a session.</param>
        public DeleteViewPortion (string userId, string itemId, string sessionId = null): base(HttpMethod.Delete, 1000)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.sessionId = sessionId;
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
                {"userId", this.UserId},
                {"itemId", this.ItemId}
            };
            if (this.SessionId != null)
                parameters["sessionId"] = this.SessionId;
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
