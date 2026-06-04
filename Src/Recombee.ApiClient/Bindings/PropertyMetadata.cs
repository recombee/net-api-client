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
    /// <summary>PropertyMetadata Binding</summary>
    [JsonObject(
        NamingStrategyType = typeof(CamelCaseNamingStrategy),
        ItemNullValueHandling = NullValueHandling.Ignore
    )]
    public class PropertyMetadata: RecombeeBinding {
        private readonly string name;
        /// <summary>Name of the [metadata](https://docs.recombee.com/api/property_roles_metadata#metadata) assigned to the property.</summary>
        public string Name
        {
            get {return name;}
        }
        private readonly Dictionary<string, object> settings;
        /// <summary>Optional configuration for this metadata entry.</summary>
        public Dictionary<string, object> Settings
        {
            get {return settings;}
        }
    
        public PropertyMetadata (string name, Dictionary<string, object> settings = null)
        {
            this.name = name;
            this.settings = settings;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is PropertyMetadata))
                 return false;
             if (obj == this)
                 return true;
        
             PropertyMetadata that = (PropertyMetadata) obj;
             return new EqualsBuilder<PropertyMetadata>(this, that)
                .With(m => m.Name)
                .With(m => m.Settings)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<PropertyMetadata>(this)
                .With(m => m.Name)
                .With(m => m.Settings)
                .HashCode;
        }
    }
    
}
