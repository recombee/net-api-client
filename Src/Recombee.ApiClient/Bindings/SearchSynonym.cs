/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Recombee.ApiClient.Util;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>SearchSynonym Binding</summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class SearchSynonym: RecombeeBinding {
        private readonly string id;
        /// <summary>Id of the synonym record</summary>
        public string Id
        {
            get {return id;}
        }
        private readonly string term;
        /// <summary>A word to which the `synonym` is specified.</summary>
        public string Term
        {
            get {return term;}
        }
        private readonly string synonym;
        /// <summary>A word that should be considered equal to `term` by the full-text search engine.</summary>
        public string Synonym
        {
            get {return synonym;}
        }
        private readonly bool oneWay;
        /// <summary>If set to `true`, only `term` -> `synonym` is considered. I set to `false`, also `synonym` -> `term` works.
        /// </summary>
        public bool OneWay
        {
            get {return oneWay;}
        }
    
        public SearchSynonym (string id, string term, string synonym, bool oneWay)
        {
            this.id = id;
            this.term = term;
            this.synonym = synonym;
            this.oneWay = oneWay;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is SearchSynonym))
                 return false;
             if (obj == this)
                 return true;
        
             SearchSynonym that = (SearchSynonym) obj;
             return new EqualsBuilder<SearchSynonym>(this, that)
                .With(m => m.Id)
                .With(m => m.Term)
                .With(m => m.Synonym)
                .With(m => m.OneWay)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<SearchSynonym>(this)
                .With(m => m.Id)
                .With(m => m.Term)
                .With(m => m.Synonym)
                .With(m => m.OneWay)
                .HashCode;
        }
    }
    
}
