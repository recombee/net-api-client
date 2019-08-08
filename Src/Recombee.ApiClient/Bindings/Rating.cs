/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Recombee.ApiClient.Util;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>Rating Binding</summary>
    public class Rating: RecombeeBinding {
        private readonly string userId;
        /// <summary>User who submitted the rating</summary>
        [JsonProperty("userId")]
        public string UserId
        {
            get {return userId;}
        }
        private readonly string itemId;
        /// <summary>Rated item</summary>
        [JsonProperty("itemId")]
        public string ItemId
        {
            get {return itemId;}
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
        private readonly double rating;
        /// <summary>Rating rescaled to interval [-1.0,1.0], where -1.0 means the worst rating possible, 0.0 means neutral, and 1.0 means absolutely positive rating. For example, in the case of 5-star evaluations, rating = (numStars-3)/2 formula may be used for the conversion.</summary>
        [JsonProperty("ratingValue")]
        public double RatingValue
        {
            get {return rating;}
        }
        private readonly string recommId;
        /// <summary>If this rating is based on a recommendation request, `recommId` is the id of the clicked recommendation.</summary>
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
    
        public Rating (string userId, string itemId, double rating, DateTime? timestamp = null, string recommId = null, Dictionary<string, object> additionalData = null)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.timestamp = timestamp;
            this.rating = rating;
            this.recommId = recommId;
            this.additionalData = additionalData;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is Rating))
                 return false;
             if (obj == this)
                 return true;
        
             Rating that = (Rating) obj;
             return new EqualsBuilder<Rating>(this, that)
                .With(m => m.UserId)
                .With(m => m.ItemId)
                .With(m => m.Timestamp)
                .With(m => m.RatingValue)
                .With(m => m.RecommId)
                .With(m => m.AdditionalData)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<Rating>(this)
                .With(m => m.UserId)
                .With(m => m.ItemId)
                .With(m => m.Timestamp)
                .With(m => m.RatingValue)
                .With(m => m.RecommId)
                .With(m => m.AdditionalData)
                .HashCode;
        }
    }
    
}
