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
    /// <summary>Delete User Property</summary>
    /// <remarks>Deleting a user property is roughly equivalent to removing a column from the table of users.
    /// </remarks>
    public class DeleteUserProperty : Request
    {
        private readonly string propertyName;
        /// <summary>Name of the property to be deleted.</summary>
        public string PropertyName
        {
            get {return propertyName;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="propertyName">Name of the property to be deleted.</param>
        public DeleteUserProperty (string propertyName): base(HttpMethod.Delete, 100000)
        {
            this.propertyName = propertyName;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/users/properties/{0}", PropertyName);
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
