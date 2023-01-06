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
    /// <summary>ListSegmentationsResponse Binding</summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ListSegmentationsResponse: RecombeeBinding {
        private readonly Segmentation[] segmentations;
        /// <summary>Array of existing Segmentations</summary>
        public Segmentation[] Segmentations
        {
            get {return segmentations;}
        }
    
        public ListSegmentationsResponse (Segmentation[] segmentations)
        {
            this.segmentations = segmentations;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is ListSegmentationsResponse))
                 return false;
             if (obj == this)
                 return true;
        
             ListSegmentationsResponse that = (ListSegmentationsResponse) obj;
             return new EqualsBuilder<ListSegmentationsResponse>(this, that)
                .With(m => m.Segmentations)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<ListSegmentationsResponse>(this)
                .With(m => m.Segmentations)
                .HashCode;
        }
    }
    
}
