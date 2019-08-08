/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Recombee.ApiClient.Util;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>ViewPortion Binding</summary>
    public class ViewPortion: RecombeeBinding {
        private readonly string userId;
        /// <summary>User who viewed a portion of the item</summary>
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
        private readonly double portion;
        /// <summary>Viewed portion of the item (number between 0.0 (viewed nothing) and 1.0 (viewed full item) ). It should be the really viewed part of the item, no matter seeking, so for example if the user seeked immediately to half of the item and then viewed 10% of the item, the `portion` should still be `0.1`.</summary>
        [JsonProperty("portion")]
        public double Portion
        {
            get {return portion;}
        }
        private readonly string sessionId;
        /// <summary>ID of session in which the user viewed the item. Default is `null` (`None`, `nil`, `NULL` etc. depending on language).</summary>
        [JsonProperty("sessionId")]
        public string SessionId
        {
            get {return sessionId;}
        }
        [JsonConverter(typeof(EpochJsonReader))]
        private readonly DateTime? timestamp;
        /// <summary>UTC timestamp of the rating as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</summary>
        [JsonConverter(typeof(EpochJsonReader))]
        [JsonProperty("timestamp")]
        public DateTime? Timestamp
        {
            get {return timestamp;}
        }
        private readonly string recommId;
        /// <summary>If this view portion is based on a recommendation request, `recommId` is the id of the clicked recommendation.</summary>
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
    
        public ViewPortion (string userId, string itemId, double portion, string sessionId = null, DateTime? timestamp = null, string recommId = null, Dictionary<string, object> additionalData = null)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.portion = portion;
            this.sessionId = sessionId;
            this.timestamp = timestamp;
            this.recommId = recommId;
            this.additionalData = additionalData;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is ViewPortion))
                 return false;
             if (obj == this)
                 return true;
        
             ViewPortion that = (ViewPortion) obj;
             return new EqualsBuilder<ViewPortion>(this, that)
                .With(m => m.UserId)
                .With(m => m.ItemId)
                .With(m => m.Portion)
                .With(m => m.SessionId)
                .With(m => m.Timestamp)
                .With(m => m.RecommId)
                .With(m => m.AdditionalData)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<ViewPortion>(this)
                .With(m => m.UserId)
                .With(m => m.ItemId)
                .With(m => m.Portion)
                .With(m => m.SessionId)
                .With(m => m.Timestamp)
                .With(m => m.RecommId)
                .With(m => m.AdditionalData)
                .HashCode;
        }
    }
    
}
