/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Recombee.ApiClient.Util;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>DetailView Binding</summary>
    public class DetailView: RecombeeBinding {
        private readonly string userId;
        /// <summary>User who viewed the item</summary>
        [JsonProperty("userId")]
        public string UserId
        {
            get {return userId;}
        }
        private readonly string itemId;
        /// <summary>Viewed item</summary>
        [JsonProperty("itemId")]
        public string ItemId
        {
            get {return itemId;}
        }
        [JsonConverter(typeof(EpochJsonReader))]
        private readonly DateTime? timestamp;
        /// <summary>UTC timestamp of the view as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</summary>
        [JsonConverter(typeof(EpochJsonReader))]
        [JsonProperty("timestamp")]
        public DateTime? Timestamp
        {
            get {return timestamp;}
        }
        private readonly long? duration;
        /// <summary>Duration of the view</summary>
        [JsonProperty("duration")]
        public long? Duration
        {
            get {return duration;}
        }
        private readonly string recommId;
        /// <summary>If this detail view is based on a recommendation request, `recommId` is the id of the clicked recommendation.</summary>
        [JsonProperty("recommId")]
        public string RecommId
        {
            get {return recommId;}
        }
        private readonly Dictionary<string, object> additionalData;
        /// <summary>A dictionary of additional data for the interaction.</summary>
        [JsonProperty("additionalData")]
        public Dictionary<string, object> AdditionalData
        {
            get {return additionalData;}
        }
    
        public DetailView (string userId, string itemId, DateTime? timestamp = null, long? duration = null, string recommId = null, Dictionary<string, object> additionalData = null)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.timestamp = timestamp;
            this.duration = duration;
            this.recommId = recommId;
            this.additionalData = additionalData;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is DetailView))
                 return false;
             if (obj == this)
                 return true;
        
             DetailView that = (DetailView) obj;
             return new EqualsBuilder<DetailView>(this, that)
                .With(m => m.UserId)
                .With(m => m.ItemId)
                .With(m => m.Timestamp)
                .With(m => m.Duration)
                .With(m => m.RecommId)
                .With(m => m.AdditionalData)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<DetailView>(this)
                .With(m => m.UserId)
                .With(m => m.ItemId)
                .With(m => m.Timestamp)
                .With(m => m.Duration)
                .With(m => m.RecommId)
                .With(m => m.AdditionalData)
                .HashCode;
        }
    }
    
}
