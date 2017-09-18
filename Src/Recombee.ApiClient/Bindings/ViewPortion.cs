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
        public string UserId
        {
            get {return userId;}
        }
        private readonly string itemId;
        /// <summary>Viewed item</summary>
        public string ItemId
        {
            get {return itemId;}
        }
        private readonly string sessionId;
        /// <summary>Id of session in which the user viewed the item</summary>
        public string SessionId
        {
            get {return sessionId;}
        }
        [JsonConverter(typeof(EpochJsonReader))]
        private readonly DateTime? timestamp;
        /// <summary>UTC timestamp of the rating as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</summary>
        [JsonConverter(typeof(EpochJsonReader))]
        public DateTime? Timestamp
        {
            get {return timestamp;}
        }
        private readonly double portion;
        /// <summary>Viewed portion of the item (number between 0.0 (viewed nothing) and 1.0 (viewed full item) ).</summary>
        public double Portion
        {
            get {return portion;}
        }
    
        public ViewPortion (string userId, string itemId, double portion, string sessionId = null, DateTime? timestamp = null)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.sessionId = sessionId;
            this.timestamp = timestamp;
            this.portion = portion;
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
                .With(m => m.SessionId)
                .With(m => m.Timestamp)
                .With(m => m.Portion)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<ViewPortion>(this)
                .With(m => m.UserId)
                .With(m => m.ItemId)
                .With(m => m.SessionId)
                .With(m => m.Timestamp)
                .With(m => m.Portion)
                .HashCode;
        }
    }
    
}
