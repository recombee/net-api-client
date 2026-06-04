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
    /// <summary>PropertyRole Binding</summary>
    [JsonObject(
        NamingStrategyType = typeof(CamelCaseNamingStrategy),
        ItemNullValueHandling = NullValueHandling.Ignore
    )]
    public class PropertyRole: RecombeeBinding {
        private readonly string name;
        /// <summary>Name of the [role](https://docs.recombee.com/api/property_roles_metadata#roles) assigned to the property.</summary>
        public string Name
        {
            get {return name;}
        }
        private readonly Dictionary<string, object> settings;
        /// <summary>Optional configuration specific to the selected role.</summary>
        public Dictionary<string, object> Settings
        {
            get {return settings;}
        }
    
        public PropertyRole (string name, Dictionary<string, object> settings = null)
        {
            this.name = name;
            this.settings = settings;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is PropertyRole))
                 return false;
             if (obj == this)
                 return true;
        
             PropertyRole that = (PropertyRole) obj;
             return new EqualsBuilder<PropertyRole>(this, that)
                .With(m => m.Name)
                .With(m => m.Settings)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<PropertyRole>(this)
                .With(m => m.Name)
                .With(m => m.Settings)
                .HashCode;
        }
    }
    
}
