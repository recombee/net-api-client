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
    /// <summary>Add Group</summary>
    /// <remarks>Creates a new group in the database.</remarks>
    public class AddGroup : Request
    {
        private readonly string groupId;
        /// <summary>ID of the group to be created.</summary>
        public string GroupId
        {
            get {return groupId;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="groupId">ID of the group to be created.</param>
        public AddGroup (string groupId): base(HttpMethod.Put, 1000)
        {
            this.groupId = groupId;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/groups/{0}", GroupId);
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
