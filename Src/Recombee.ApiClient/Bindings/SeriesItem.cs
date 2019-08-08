/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Recombee.ApiClient.Util;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>SeriesItem Binding</summary>
    public class SeriesItem: RecombeeBinding {
        private readonly string itemType;
        /// <summary>`item` iff the regular item from the catalog is to be inserted, `series` iff series is inserted as the item.</summary>
        [JsonProperty("itemType")]
        public string ItemType
        {
            get {return itemType;}
        }
        private readonly string itemId;
        /// <summary>ID of the item iff `itemType` is `item`. ID of the series iff `itemType` is `series`.</summary>
        [JsonProperty("itemId")]
        public string ItemId
        {
            get {return itemId;}
        }
        private readonly double time;
        /// <summary>Time index used for sorting items in the series. According to time, items are sorted within series in ascending order. In the example of TV show episodes, the episode number is a natural choice to be passed as time.</summary>
        [JsonProperty("time")]
        public double Time
        {
            get {return time;}
        }
    
        public SeriesItem (string itemType, string itemId, double time)
        {
            this.itemType = itemType;
            this.itemId = itemId;
            this.time = time;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is SeriesItem))
                 return false;
             if (obj == this)
                 return true;
        
             SeriesItem that = (SeriesItem) obj;
             return new EqualsBuilder<SeriesItem>(this, that)
                .With(m => m.ItemType)
                .With(m => m.ItemId)
                .With(m => m.Time)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<SeriesItem>(this)
                .With(m => m.ItemType)
                .With(m => m.ItemId)
                .With(m => m.Time)
                .HashCode;
        }
    }
    
}
