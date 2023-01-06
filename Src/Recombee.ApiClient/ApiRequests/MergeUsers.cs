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
    /// <summary>Merge Users</summary>
    /// <remarks>Merges interactions (purchases, ratings, bookmarks, detail views ...) of two different users under a single user ID. This is especially useful for online e-commerce applications working with anonymous users identified by unique tokens such as the session ID. In such applications, it may often happen that a user owns a persistent account, yet accesses the system anonymously while, e.g., putting items into a shopping cart. At some point in time, such as when the user wishes to confirm the purchase, (s)he logs into the system using his/her username and password. The interactions made under anonymous session ID then become connected with the persistent account, and merging these two becomes desirable.
    /// Merging happens between two users referred to as the *target* and the *source*. After the merge, all the interactions of the source user are attributed to the target user, and the source user is **deleted**.
    /// </remarks>
    public class MergeUsers : Request
    {
        private readonly string targetUserId;
        /// <summary>ID of the target user.</summary>
        public string TargetUserId
        {
            get {return targetUserId;}
        }
        private readonly string sourceUserId;
        /// <summary>ID of the source user.</summary>
        public string SourceUserId
        {
            get {return sourceUserId;}
        }
        private readonly bool? cascadeCreate;
        /// <summary>Sets whether the user *targetUserId* should be created if not present in the database.</summary>
        public bool? CascadeCreate
        {
            get {return cascadeCreate;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="targetUserId">ID of the target user.</param>
        /// <param name="sourceUserId">ID of the source user.</param>
        /// <param name="cascadeCreate">Sets whether the user *targetUserId* should be created if not present in the database.</param>
        public MergeUsers (string targetUserId, string sourceUserId, bool? cascadeCreate = null): base(HttpMethod.Put, 10000)
        {
            this.targetUserId = targetUserId;
            this.sourceUserId = sourceUserId;
            this.cascadeCreate = cascadeCreate;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/users/{0}/merge/{1}", TargetUserId, SourceUserId);
        }
    
        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> QueryParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
        
            };
            if (this.CascadeCreate.HasValue)
                parameters["cascadeCreate"] = this.CascadeCreate.Value;
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
