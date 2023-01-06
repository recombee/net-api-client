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
    /// <summary>Add Rating</summary>
    /// <remarks>Adds a rating of the given item made by the given user.
    /// </remarks>
    public class AddRating : Request
    {
        private readonly string userId;
        /// <summary>User who submitted the rating</summary>
        public string UserId
        {
            get {return userId;}
        }
        private readonly string itemId;
        /// <summary>Rated item</summary>
        public string ItemId
        {
            get {return itemId;}
        }
        private readonly DateTime? timestamp;
        /// <summary>UTC timestamp of the rating as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</summary>
        public DateTime? Timestamp
        {
            get {return timestamp;}
        }
        private readonly double rating;
        /// <summary>Rating rescaled to interval [-1.0,1.0], where -1.0 means the worst rating possible, 0.0 means neutral, and 1.0 means absolutely positive rating. For example, in the case of 5-star evaluations, rating = (numStars-3)/2 formula may be used for the conversion.</summary>
        public double Rating
        {
            get {return rating;}
        }
        private readonly bool? cascadeCreate;
        /// <summary>Sets whether the given user/item should be created if not present in the database.</summary>
        public bool? CascadeCreate
        {
            get {return cascadeCreate;}
        }
        private readonly string recommId;
        /// <summary>If this rating is based on a recommendation request, `recommId` is the id of the clicked recommendation.</summary>
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
        /// <param name="userId">User who submitted the rating</param>
        /// <param name="itemId">Rated item</param>
        /// <param name="timestamp">UTC timestamp of the rating as ISO8601-1 pattern or UTC epoch time. The default value is the current time.</param>
        /// <param name="rating">Rating rescaled to interval [-1.0,1.0], where -1.0 means the worst rating possible, 0.0 means neutral, and 1.0 means absolutely positive rating. For example, in the case of 5-star evaluations, rating = (numStars-3)/2 formula may be used for the conversion.</param>
        /// <param name="cascadeCreate">Sets whether the given user/item should be created if not present in the database.</param>
        /// <param name="recommId">If this rating is based on a recommendation request, `recommId` is the id of the clicked recommendation.</param>
        /// <param name="additionalData">A dictionary of additional data for the interaction.</param>
        public AddRating (string userId, string itemId, double rating, DateTime? timestamp = null, bool? cascadeCreate = null, string recommId = null, Dictionary<string, object> additionalData = null): base(HttpMethod.Post, 1000)
        {
            this.userId = userId;
            this.itemId = itemId;
            this.timestamp = timestamp;
            this.rating = rating;
            this.cascadeCreate = cascadeCreate;
            this.recommId = recommId;
            this.additionalData = additionalData;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/ratings/";
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
                {"itemId", this.ItemId},
                {"rating", this.Rating}
            };
            if (this.Timestamp.HasValue)
                parameters["timestamp"] = ConvertToUnixTimestamp(this.Timestamp.Value);
            if (this.CascadeCreate.HasValue)
                parameters["cascadeCreate"] = this.CascadeCreate.Value;
            if (this.RecommId != null)
                parameters["recommId"] = this.RecommId;
            if (this.AdditionalData != null)
                parameters["additionalData"] = this.AdditionalData;
            return parameters;
        }
    
    }
}
