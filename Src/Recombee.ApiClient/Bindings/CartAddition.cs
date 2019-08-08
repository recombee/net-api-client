/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Recombee.ApiClient.Util;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>CartAddition Binding</summary>
    public class CartAddition: RecombeeBinding {
        private readonly string userId;
        /// <summary>User who added the item to the cart</summary>
        [JsonProperty("userId")]
        public string UserId
        {
            get {return userId;}
        }
        private readonly string itemId;
        /// <summary>Item added to the cart</summary>
        [JsonProperty("itemId")]
        public string ItemId
        {
            get {return itemId;}
        }
        [JsonConverter(typeof(EpochJsonReader))]
        private readonly DateTime? timestamp;
        /// <summary>UTC timestamp of the cart addition as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</summary>
        [JsonConverter(typeof(EpochJsonReader))]
        [JsonProperty("timeStamp")]
        public DateTime? Timestamp
        {
            get {return timestamp;}
        }
        private readonly double? amount;
        /// <summary>Amount (number) added to cart. The default is 1. For example if `user-x` adds two `item-y` during a single order (session...), the `amount` should equal to 2.</summary>
        [JsonProperty("amount")]
        public double? Amount
        {
            get {return amount;}
        }
        private readonly double? price;
        /// <summary>Price of the added item. If `amount` is greater than 1, sum of prices of all the items should be given.</summary>
        [JsonProperty("price")]
        public double? Price
        {
            get {return price;}
        }
        private readonly string recommId;
        /// <summary>If this cart addition is based on a recommendation request, `recommId` is the id of the clicked recommendation.</summary>
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
    
        public CartAddition (string userId, string itemId, DateTime? timestamp = null, double? amount = null, double? price = null, string recommId = null, Dictionary<string, object> additionalData = null)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.timestamp = timestamp;
            this.amount = amount;
            this.price = price;
            this.recommId = recommId;
            this.additionalData = additionalData;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is CartAddition))
                 return false;
             if (obj == this)
                 return true;
        
             CartAddition that = (CartAddition) obj;
             return new EqualsBuilder<CartAddition>(this, that)
                .With(m => m.UserId)
                .With(m => m.ItemId)
                .With(m => m.Timestamp)
                .With(m => m.Amount)
                .With(m => m.Price)
                .With(m => m.RecommId)
                .With(m => m.AdditionalData)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<CartAddition>(this)
                .With(m => m.UserId)
                .With(m => m.ItemId)
                .With(m => m.Timestamp)
                .With(m => m.Amount)
                .With(m => m.Price)
                .With(m => m.RecommId)
                .With(m => m.AdditionalData)
                .HashCode;
        }
    }
    
}
