/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Recombee.ApiClient.Util;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>RecommendationResponse Binding</summary>
    public class RecommendationResponse: RecombeeBinding {
        private readonly string requestId;
        /// <summary>Id of the recommendation request</summary>
        public string RequestId
        {
            get {return requestId;}
        }
        private readonly Recommendation[] recomms;
        /// <summary>Obtained recommendations</summary>
        public Recommendation[] Recomms
        {
            get {return recomms;}
        }
    
        public RecommendationResponse (string requestId, Recommendation[] recomms)
        {
            this.requestId = requestId;
            this.recomms = recomms;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is RecommendationResponse))
                 return false;
             if (obj == this)
                 return true;
        
             RecommendationResponse that = (RecommendationResponse) obj;
             return new EqualsBuilder<RecommendationResponse>(this, that)
                .With(m => m.RequestId)
                .With(m => m.Recomms)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<RecommendationResponse>(this)
                .With(m => m.RequestId)
                .With(m => m.Recomms)
                .HashCode;
        }
    }
    
}
