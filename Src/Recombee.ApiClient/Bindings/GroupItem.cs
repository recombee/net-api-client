/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Recombee.ApiClient.Util;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>GroupItem Binding</summary>
    public class GroupItem: RecombeeBinding {
        private readonly string itemType;
        /// <summary>`item` iff the regular item from the catalog is to be inserted, `group` iff group is inserted as the item.</summary>
        [JsonProperty("itemType")]
        public string ItemType
        {
            get {return itemType;}
        }
        private readonly string itemId;
        /// <summary>ID of the item iff `itemType` is `item`. ID of the group iff `itemType` is `group`.</summary>
        [JsonProperty("itemId")]
        public string ItemId
        {
            get {return itemId;}
        }
    
        public GroupItem (string itemType, string itemId)
        {
            this.itemType = itemType;
            this.itemId = itemId;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is GroupItem))
                 return false;
             if (obj == this)
                 return true;
        
             GroupItem that = (GroupItem) obj;
             return new EqualsBuilder<GroupItem>(this, that)
                .With(m => m.ItemType)
                .With(m => m.ItemId)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<GroupItem>(this)
                .With(m => m.ItemType)
                .With(m => m.ItemId)
                .HashCode;
        }
    }
    
}
