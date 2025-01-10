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
    /// <summary>Add Cart Addition</summary>
    /// <remarks>Adds a cart addition of the given item made by the given user.
    /// </remarks>
    public class AddCartAddition : Request
    {
        private readonly string userId;
        /// <summary>User who added the item to the cart</summary>
        public string UserId
        {
            get {return userId;}
        }
        private readonly string itemId;
        /// <summary>Item added to the cart</summary>
        public string ItemId
        {
            get {return itemId;}
        }
        private readonly DateTime? timestamp;
        /// <summary>UTC timestamp of the cart addition as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</summary>
        public DateTime? Timestamp
        {
            get {return timestamp;}
        }
        private readonly bool? cascadeCreate;
        /// <summary>Sets whether the given user/item should be created if not present in the database.</summary>
        public bool? CascadeCreate
        {
            get {return cascadeCreate;}
        }
        private readonly double? amount;
        /// <summary>Amount (number) added to cart. The default is 1. For example, if `user-x` adds two `item-y` during a single order (session...), the `amount` should equal 2.</summary>
        public double? Amount
        {
            get {return amount;}
        }
        private readonly double? price;
        /// <summary>Price of the added item. If `amount` is greater than 1, the sum of prices of all the items should be given.</summary>
        public double? Price
        {
            get {return price;}
        }
        private readonly string recommId;
        /// <summary>If this cart addition is based on a recommendation request, `recommId` is the id of the clicked recommendation.</summary>
        public string RecommId
        {
            get {return recommId;}
        }
        private readonly Dictionary<string, object> additionalData;
        /// <summary>A dictionary of additional data for the interaction.</summary>
        public Dictionary<string, object> AdditionalData
        {
            get {return additionalData;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="userId">User who added the item to the cart</param>
        /// <param name="itemId">Item added to the cart</param>
        /// <param name="timestamp">UTC timestamp of the cart addition as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</param>
        /// <param name="cascadeCreate">Sets whether the given user/item should be created if not present in the database.</param>
        /// <param name="amount">Amount (number) added to cart. The default is 1. For example, if `user-x` adds two `item-y` during a single order (session...), the `amount` should equal 2.</param>
        /// <param name="price">Price of the added item. If `amount` is greater than 1, the sum of prices of all the items should be given.</param>
        /// <param name="recommId">If this cart addition is based on a recommendation request, `recommId` is the id of the clicked recommendation.</param>
        /// <param name="additionalData">A dictionary of additional data for the interaction.</param>
        public AddCartAddition (string userId, string itemId, DateTime? timestamp = null, bool? cascadeCreate = null, double? amount = null, double? price = null, string recommId = null, Dictionary<string, object> additionalData = null): base(HttpMethod.Post, 3000)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.timestamp = timestamp;
            this.cascadeCreate = cascadeCreate;
            this.amount = amount;
            this.price = price;
            this.recommId = recommId;
            this.additionalData = additionalData;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/cartadditions/";
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
                {"userId", this.UserId},
                {"itemId", this.ItemId}
            };
            if (this.Timestamp.HasValue)
                parameters["timestamp"] = ConvertToUnixTimestamp(this.Timestamp.Value);
            if (this.CascadeCreate.HasValue)
                parameters["cascadeCreate"] = this.CascadeCreate.Value;
            if (this.Amount.HasValue)
                parameters["amount"] = this.Amount.Value;
            if (this.Price.HasValue)
                parameters["price"] = this.Price.Value;
            if (this.RecommId != null)
                parameters["recommId"] = this.RecommId;
            if (this.AdditionalData != null)
                parameters["additionalData"] = this.AdditionalData;
            return parameters;
        }
    
    }
}
