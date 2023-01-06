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
    /// <summary>Add Search Synonym</summary>
    /// <remarks>Adds a new synonym for the [Search items](https://docs.recombee.com/api.html#search-items).
    /// When the `term` is used in the search query, the `synonym` is also used for the full-text search.
    /// Unless `oneWay=true`, it works also in the opposite way (`synonym` -> `term`).
    /// An example of a synonym can be `science fiction` for the term `sci-fi`.
    /// </remarks>
    public class AddSearchSynonym : Request
    {
        private readonly string term;
        /// <summary>A word to which the `synonym` is specified.</summary>
        public string Term
        {
            get {return term;}
        }
        private readonly string synonym;
        /// <summary>A word that should be considered equal to the `term` by the full-text search engine.</summary>
        public string Synonym
        {
            get {return synonym;}
        }
        private readonly bool? oneWay;
        /// <summary>If set to `true`, only `term` -> `synonym` is considered. If set to `false`, also `synonym` -> `term` works.
        /// Default: `false`.
        /// </summary>
        public bool? OneWay
        {
            get {return oneWay;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="term">A word to which the `synonym` is specified.</param>
        /// <param name="synonym">A word that should be considered equal to the `term` by the full-text search engine.</param>
        /// <param name="oneWay">If set to `true`, only `term` -> `synonym` is considered. If set to `false`, also `synonym` -> `term` works.
        /// Default: `false`.
        /// </param>
        public AddSearchSynonym (string term, string synonym, bool? oneWay = null): base(HttpMethod.Post, 10000)
        {
            this.term = term;
            this.synonym = synonym;
            this.oneWay = oneWay;
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
            return parameters;
        }
    
        /// <summary>Get body parameters</summary>
        /// <returns>Dictionary containing  values of body parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> BodyParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
                {"term", this.Term},
                {"synonym", this.Synonym}
            };
            if (this.OneWay.HasValue)
                parameters["oneWay"] = this.OneWay.Value;
            return parameters;
        }
    
    }
}
