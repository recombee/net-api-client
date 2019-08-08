/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Recombee.ApiClient.Util;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>Logic Binding</summary>
    public class Logic: RecombeeBinding {
        private readonly string name;
        /// <summary>Name of the logic that should be used</summary>
        [JsonProperty("name")]
        public string Name
        {
            get {return name;}
        }
        private readonly Dictionary<string, object> settings;
        /// <summary>Parameters passed to the logic</summary>
        [JsonProperty("settings")]
        public Dictionary<string, object> Settings
        {
            get {return settings;}
        }
    
        public Logic (string name, Dictionary<string, object> settings = null)
        {
            this.name = name;
            this.settings = settings;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is Logic))
                 return false;
             if (obj == this)
                 return true;
        
             Logic that = (Logic) obj;
             return new EqualsBuilder<Logic>(this, that)
                .With(m => m.Name)
                .With(m => m.Settings)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<Logic>(this)
                .With(m => m.Name)
                .With(m => m.Settings)
                .HashCode;
        }
    }
    
}
