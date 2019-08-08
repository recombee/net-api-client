/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Recombee.ApiClient.Util;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>Series Binding</summary>
    public class Series: Entity {
        private readonly string seriesId;
        /// <summary>Id of the series</summary>
        [JsonProperty("seriesId")]
        public string SeriesId
        {
            get {return seriesId;}
        }
    
        public Series (string seriesId, Dictionary<string, object> values = null): base(values)
        {
            this.seriesId = seriesId;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is Series))
                 return false;
             if (obj == this)
                 return true;
        
             Series that = (Series) obj;
             return new EqualsBuilder<Series>(this, that)
                .With(m => m.SeriesId)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<Series>(this)
                .With(m => m.SeriesId)
                .HashCode;
        }
    }
    
}
