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
    /// <summary>ListSearchSynonymsResponse Binding</summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ListSearchSynonymsResponse: RecombeeBinding {
        private readonly SearchSynonym[] synonyms;
        /// <summary>Defined search synonyms.
        /// </summary>
        public SearchSynonym[] Synonyms
        {
            get {return synonyms;}
        }
    
        public ListSearchSynonymsResponse (SearchSynonym[] synonyms)
        {
            this.synonyms = synonyms;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is ListSearchSynonymsResponse))
                 return false;
             if (obj == this)
                 return true;
        
             ListSearchSynonymsResponse that = (ListSearchSynonymsResponse) obj;
             return new EqualsBuilder<ListSearchSynonymsResponse>(this, that)
                .With(m => m.Synonyms)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<ListSearchSynonymsResponse>(this)
                .With(m => m.Synonyms)
                .HashCode;
        }
    }
    
}
