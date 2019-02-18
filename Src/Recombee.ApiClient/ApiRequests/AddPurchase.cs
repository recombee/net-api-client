/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using Recombee.ApiClient.Util;


namespace Recombee.ApiClient.ApiRequests
{
    /// <summary>Add purchase</summary>
    /// <remarks>Adds a purchase of a given item made by a given user.
    /// </remarks>
    public class AddPurchase : Request
    {
        private readonly string userId;
        /// <summary>User who purchased the item</summary>
        public string UserId
        {
            get {return userId;}
        }
        private readonly string itemId;
        /// <summary>Purchased item</summary>
        public string ItemId
        {
            get {return itemId;}
        }
        private readonly DateTime? timestamp;
        /// <summary>UTC timestamp of the purchase as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</summary>
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
        /// <summary>Amount (number) of purchased items. The default is 1. For example if `user-x` purchases two `item-y` during a single order (session...), the `amount` should equal to 2.</summary>
        public double? Amount
        {
            get {return amount;}
        }
        private readonly double? price;
        /// <summary>Price paid by the user for the item. If `amount` is greater than 1, sum of prices of all the items should be given.</summary>
        public double? Price
        {
            get {return price;}
        }
        private readonly double? profit;
        /// <summary>Your profit from the purchased item. The profit is natural in e-commerce domain (for example if `user-x` purchases `item-y` for $100 and the gross margin is 30 %, then the profit is $30), but is applicable also in other domains (for example at a news company it may be income from displayed advertisement on article page). If `amount` is greater than 1, sum of profit of all the items should be given.</summary>
        public double? Profit
        {
            get {return profit;}
        }
        private readonly string recommId;
        /// <summary>If this purchase is based on a recommendation request, `recommId` is the id of the clicked recommendation.</summary>
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
        /// <param name="userId">User who purchased the item</param>
        /// <param name="itemId">Purchased item</param>
        /// <param name="timestamp">UTC timestamp of the purchase as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</param>
        /// <param name="cascadeCreate">Sets whether the given user/item should be created if not present in the database.</param>
        /// <param name="amount">Amount (number) of purchased items. The default is 1. For example if `user-x` purchases two `item-y` during a single order (session...), the `amount` should equal to 2.</param>
        /// <param name="price">Price paid by the user for the item. If `amount` is greater than 1, sum of prices of all the items should be given.</param>
        /// <param name="profit">Your profit from the purchased item. The profit is natural in e-commerce domain (for example if `user-x` purchases `item-y` for $100 and the gross margin is 30 %, then the profit is $30), but is applicable also in other domains (for example at a news company it may be income from displayed advertisement on article page). If `amount` is greater than 1, sum of profit of all the items should be given.</param>
        /// <param name="recommId">If this purchase is based on a recommendation request, `recommId` is the id of the clicked recommendation.</param>
        /// <param name="additionalData">A dictionary of additional data for the interaction.</param>
        public AddPurchase (string userId, string itemId, DateTime? timestamp = null, bool? cascadeCreate = null, double? amount = null, double? price = null, double? profit = null, string recommId = null, Dictionary<string, object> additionalData = null): base(HttpMethod.Post, 1000)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.timestamp = timestamp;
            this.cascadeCreate = cascadeCreate;
            this.amount = amount;
            this.price = price;
            this.profit = profit;
            this.recommId = recommId;
            this.additionalData = additionalData;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/purchases/";
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
                {"userId", UserId},
                {"itemId", ItemId}
            };
            if (Timestamp.HasValue)
                parameters["timestamp"] = ConvertToUnixTimestamp(Timestamp.Value);
            if (CascadeCreate.HasValue)
                parameters["cascadeCreate"] = CascadeCreate.Value;
            if (Amount.HasValue)
                parameters["amount"] = Amount.Value;
            if (Price.HasValue)
                parameters["price"] = Price.Value;
            if (Profit.HasValue)
                parameters["profit"] = Profit.Value;
            if (RecommId != null)
                parameters["recommId"] = RecommId;
            if (AdditionalData != null)
                parameters["additionalData"] = AdditionalData;
            return parameters;
        }
    
    }
}
