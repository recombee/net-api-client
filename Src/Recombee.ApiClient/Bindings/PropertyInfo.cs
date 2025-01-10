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
    /// <summary>PropertyInfo Binding</summary>
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PropertyInfo: RecombeeBinding {
        private readonly string name;
        /// <summary>Name of the property</summary>
        public string Name
        {
            get {return name;}
        }
        private readonly string type;
        /// <summary>Type of the property</summary>
        public string Type
        {
            get {return type;}
        }
    
        public PropertyInfo (string name, string type)
        {
            this.name = name;
            this.type = type;
        }
    
        /// <summary>Determines whether the specified object is equal to the current object</summary>
        /// <param name="obj">The object to compare with the current object</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false</returns>
        public override bool Equals(Object obj)
        {
             if (!(obj is PropertyInfo))
                 return false;
             if (obj == this)
                 return true;
        
             PropertyInfo that = (PropertyInfo) obj;
             return new EqualsBuilder<PropertyInfo>(this, that)
                .With(m => m.Name)
                .With(m => m.Type)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<PropertyInfo>(this)
                .With(m => m.Name)
                .With(m => m.Type)
                .HashCode;
        }
    }
    
}
