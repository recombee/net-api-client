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
    /// <summary>Segmentation Binding</summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Segmentation: RecombeeBinding {
        private readonly string segmentationId;
        /// <summary>Id of the Segmentation</summary>
        public string SegmentationId
        {
            get {return segmentationId;}
        }
        private readonly string sourceType;
        /// <summary>Determines on which type of data (e.g. `items`) the Segmentation is based</summary>
        public string SourceType
        {
            get {return sourceType;}
        }
        private readonly string segmentationType;
        /// <summary>Determines the type of the segmentation (Property-based, Manual ReQL, Auto ReQL)</summary>
        public string SegmentationType
        {
            get {return segmentationType;}
        }
        private readonly string title;
        /// <summary>Title of the Segmentation</summary>
        public string Title
        {
            get {return title;}
        }
        private readonly string description;
        /// <summary>Description of the Segmentation</summary>
        public string Description
        {
            get {return description;}
        }
    
        public Segmentation (string segmentationId, string sourceType, string segmentationType, string title = null, string description = null)
        {
            this.segmentationId = segmentationId;
            this.sourceType = sourceType;
            this.segmentationType = segmentationType;
            this.title = title;
            this.description = description;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is Segmentation))
                 return false;
             if (obj == this)
                 return true;
        
             Segmentation that = (Segmentation) obj;
             return new EqualsBuilder<Segmentation>(this, that)
                .With(m => m.SegmentationId)
                .With(m => m.SourceType)
                .With(m => m.SegmentationType)
                .With(m => m.Title)
                .With(m => m.Description)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<Segmentation>(this)
                .With(m => m.SegmentationId)
                .With(m => m.SourceType)
                .With(m => m.SegmentationType)
                .With(m => m.Title)
                .With(m => m.Description)
                .HashCode;
        }
    }
    
}
