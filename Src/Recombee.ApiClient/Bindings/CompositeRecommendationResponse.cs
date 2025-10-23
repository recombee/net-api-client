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
    /// <summary>CompositeRecommendationResponse Binding</summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CompositeRecommendationResponse: RecombeeBinding {
        private readonly string recommId;
        /// <summary>Id of the composite recommendation request</summary>
        public string RecommId
        {
            get {return recommId;}
        }
        private readonly Recommendation source;
        /// <summary>Parameters of the source stage</summary>
        public Recommendation Source
        {
            get {return source;}
        }
        private readonly Recommendation[] recomms;
        /// <summary>Obtained recommendations</summary>
        public Recommendation[] Recomms
        {
            get {return recomms;}
        }
        private readonly long? numberNextRecommsCalls;
        /// <summary>How many times *Recommend Next Items* have been called for this `recommId`</summary>
        public long? NumberNextRecommsCalls
        {
            get {return numberNextRecommsCalls;}
        }
    
        public CompositeRecommendationResponse (string recommId, Recommendation source, Recommendation[] recomms, long? numberNextRecommsCalls = null)
        {
            this.recommId = recommId;
            this.source = source;
            this.recomms = recomms;
            this.numberNextRecommsCalls = numberNextRecommsCalls;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is CompositeRecommendationResponse))
                 return false;
             if (obj == this)
                 return true;
        
             CompositeRecommendationResponse that = (CompositeRecommendationResponse) obj;
             return new EqualsBuilder<CompositeRecommendationResponse>(this, that)
                .With(m => m.RecommId)
                .With(m => m.Source)
                .With(m => m.Recomms)
                .With(m => m.NumberNextRecommsCalls)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<CompositeRecommendationResponse>(this)
                .With(m => m.RecommId)
                .With(m => m.Source)
                .With(m => m.Recomms)
                .With(m => m.NumberNextRecommsCalls)
                .HashCode;
        }
    }
    
}
