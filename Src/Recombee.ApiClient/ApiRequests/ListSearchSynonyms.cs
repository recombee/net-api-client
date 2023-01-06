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
    /// <summary>List Search Synonyms</summary>
    /// <remarks>Gives the list of synonyms defined in the database.</remarks>
    public class ListSearchSynonyms : Request
    {
        private readonly long? count;
        /// <summary>The number of synonyms to be listed.</summary>
        public long? Count
        {
            get {return count;}
        }
        private readonly long? offset;
        /// <summary>Specifies the number of synonyms to skip (ordered by `term`).</summary>
        public long? Offset
        {
            get {return offset;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="count">The number of synonyms to be listed.</param>
        /// <param name="offset">Specifies the number of synonyms to skip (ordered by `term`).</param>
        public ListSearchSynonyms (long? count = null, long? offset = null): base(HttpMethod.Get, 100000)
        {
            this.count = count;
            this.offset = offset;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/synonyms/items/";
        }
    
        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> QueryParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
        
            };
            if (this.Count.HasValue)
                parameters["count"] = this.Count.Value;
            if (this.Offset.HasValue)
                parameters["offset"] = this.Offset.Value;
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
