/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Recombee.ApiClient.Util;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>Item Binding</summary>
    public class Item: Entity {
        private readonly string itemId;
        /// <summary>Id of the item</summary>
        [JsonProperty("itemId")]
        public string ItemId
        {
            get {return itemId;}
        }
    
        public Item (string itemId, Dictionary<string, object> values = null): base(values)
        {
            this.itemId = itemId;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is Item))
                 return false;
             if (obj == this)
                 return true;
        
             Item that = (Item) obj;
             return new EqualsBuilder<Item>(this, that)
                .With(m => m.ItemId)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<Item>(this)
                .With(m => m.ItemId)
                .HashCode;
        }
    }
    
}
