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
    /// <summary>Scenario Binding</summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Scenario: RecombeeBinding {
        private readonly string id;
        /// <summary>ID of the Scenario</summary>
        public string Id
        {
            get {return id;}
        }
        private readonly string endpoint;
        /// <summary>Scenario endpoint defined in the Admin UI</summary>
        public string Endpoint
        {
            get {return endpoint;}
        }
    
        public Scenario (string id, string endpoint)
        {
            this.id = id;
            this.endpoint = endpoint;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is Scenario))
                 return false;
             if (obj == this)
                 return true;
        
             Scenario that = (Scenario) obj;
             return new EqualsBuilder<Scenario>(this, that)
                .With(m => m.Id)
                .With(m => m.Endpoint)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<Scenario>(this)
                .With(m => m.Id)
                .With(m => m.Endpoint)
                .HashCode;
        }
    }
    
}
