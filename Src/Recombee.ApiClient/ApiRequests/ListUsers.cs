/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using Recombee.ApiClient.Util;


namespace Recombee.ApiClient.ApiRequests
{
    /// <summary>List users</summary>
    /// <remarks>Gets a list of IDs of users currently present in the catalog.</remarks>
    public class ListUsers : Request
    {
        private readonly string filter;
        /// <summary>Boolean-returning [ReQL](https://docs.recombee.com/reql.html) expression, which allows you to filter users to be listed. Only the users for which the expression is *true* will be returned.</summary>
        public string Filter
        {
            get {return filter;}
        }
        private readonly long? count;
        /// <summary>The number of users to be listed.</summary>
        public long? Count
        {
            get {return count;}
        }
        private readonly long? offset;
        /// <summary>Specifies the number of users to skip (ordered by `userId`).</summary>
        public long? Offset
        {
            get {return offset;}
        }
        private readonly bool? returnProperties;
        /// <summary>With `returnProperties=true`, property values of the listed users are returned along with their IDs in a JSON dictionary. 
        /// Example response:
        /// ```
        ///   [
        ///     {
        ///       "userId": "user-81",
        ///       "country": "US",
        ///       "sex": "M"
        ///     },
        ///     {
        ///       "userId": "user-314",
        ///       "country": "CAN",
        ///       "sex": "F"
        ///     }
        ///   ]
        /// ```
        /// </summary>
        public bool? ReturnProperties
        {
            get {return returnProperties;}
        }
        private readonly string[] includedProperties;
        /// <summary>Allows to specify, which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list. 
        /// Example response for `includedProperties=country`:
        /// ```
        ///   [
        ///     {
        ///       "userId": "user-81",
        ///       "country": "US"
        ///     },
        ///     {
        ///       "userId": "user-314",
        ///       "country": "CAN"
        ///     }
        ///   ]
        /// ```
        /// </summary>
        public string[] IncludedProperties
        {
            get {return includedProperties;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="filter">Boolean-returning [ReQL](https://docs.recombee.com/reql.html) expression, which allows you to filter users to be listed. Only the users for which the expression is *true* will be returned.</param>
        /// <param name="count">The number of users to be listed.</param>
        /// <param name="offset">Specifies the number of users to skip (ordered by `userId`).</param>
        /// <param name="returnProperties">With `returnProperties=true`, property values of the listed users are returned along with their IDs in a JSON dictionary. 
        /// Example response:
        /// ```
        ///   [
        ///     {
        ///       "userId": "user-81",
        ///       "country": "US",
        ///       "sex": "M"
        ///     },
        ///     {
        ///       "userId": "user-314",
        ///       "country": "CAN",
        ///       "sex": "F"
        ///     }
        ///   ]
        /// ```
        /// </param>
        /// <param name="includedProperties">Allows to specify, which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list. 
        /// Example response for `includedProperties=country`:
        /// ```
        ///   [
        ///     {
        ///       "userId": "user-81",
        ///       "country": "US"
        ///     },
        ///     {
        ///       "userId": "user-314",
        ///       "country": "CAN"
        ///     }
        ///   ]
        /// ```
        /// </param>
        public ListUsers (string filter = null, long? count = null, long? offset = null, bool? returnProperties = null, string[] includedProperties = null): base(HttpMethod.Get, 100000)
        {
            this.filter = filter;
            this.count = count;
            this.offset = offset;
            this.returnProperties = returnProperties;
            this.includedProperties = includedProperties;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/users/list/";
        }
    
        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> QueryParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
        
            };
            if (Filter != null)
                parameters["filter"] = Filter;
            if (Count.HasValue)
                parameters["count"] = Count.Value;
            if (Offset.HasValue)
                parameters["offset"] = Offset.Value;
            if (ReturnProperties.HasValue)
                parameters["returnProperties"] = ReturnProperties.Value;
            if (IncludedProperties != null)
                parameters["includedProperties"] = string.Join(",", IncludedProperties);
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
