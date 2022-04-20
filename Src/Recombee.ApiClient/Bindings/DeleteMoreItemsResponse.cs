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
    /// <summary>DeleteMoreItemsResponse Binding</summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class DeleteMoreItemsResponse: RecombeeBinding {
        private readonly long count;
        /// <summary>Number of deleted items</summary>
        public long Count
        {
            get {return count;}
        }
        private readonly string[] itemIds;
        /// <summary>IDs of deleted items</summary>
        public string[] ItemIds
        {
            get {return itemIds;}
        }
    
        public DeleteMoreItemsResponse (long count, string[] itemIds)
        {
            this.count = count;
            this.itemIds = itemIds;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is DeleteMoreItemsResponse))
                 return false;
             if (obj == this)
                 return true;
        
             DeleteMoreItemsResponse that = (DeleteMoreItemsResponse) obj;
             return new EqualsBuilder<DeleteMoreItemsResponse>(this, that)
                .With(m => m.Count)
                .With(m => m.ItemIds)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<DeleteMoreItemsResponse>(this)
                .With(m => m.Count)
                .With(m => m.ItemIds)
                .HashCode;
        }
    }
    
}
