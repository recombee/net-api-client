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
        private readonly string recommId;
        /// <summary>Id of the recommendation request</summary>
        public string RecommId
        {
            get {return recommId;}
        }
        private readonly Recommendation[] recomms;
        /// <summary>Obtained recommendations</summary>
        public Recommendation[] Recomms
        {
            get {return recomms;}
        }
        private readonly string abGroup;
        /// <summary>Name of AB-testing group to which the request belongs if there is a custom AB-testing running</summary>
        public string AbGroup
        {
            get {return abGroup;}
        }

        // public RecommendationResponse(string recommId, Recommendation[] recomms): this(recommId, recomms, null)
        // {}
    
        public RecommendationResponse (string recommId, Recommendation[] recomms, string abGroup=null)
        {
            this.recommId = recommId;
            this.recomms = recomms;
            this.abGroup = abGroup;
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
                .With(m => m.recommId)
                .With(m => m.Recomms)
                .With(m => m.AbGroup)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<RecommendationResponse>(this)
                .With(m => m.recommId)
                .With(m => m.Recomms)
                .With(m => m.AbGroup)
                .HashCode;
        }
    }
    
}
