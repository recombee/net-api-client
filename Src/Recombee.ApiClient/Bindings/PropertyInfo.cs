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
        private readonly PropertyRole role;
        /// <summary>[Role](https://docs.recombee.com/api/property_roles_metadata#roles) assigned to the property.
        /// Role defines how the property is interpreted by the system.
        /// </summary>
        public PropertyRole Role
        {
            get {return role;}
        }
        private readonly PropertyMetadata[] metadata;
        /// <summary>[Metadata](https://docs.recombee.com/api/property_roles_metadata#metadata) entries associated with the property.
        /// Metadata provides additional configuration or annotations that influence how the property is processed.
        /// </summary>
        public PropertyMetadata[] Metadata
        {
            get {return metadata;}
        }
    
        public PropertyInfo (string name, string type, PropertyRole role = null, PropertyMetadata[] metadata = null)
        {
            this.name = name;
            this.type = type;
            this.role = role;
            this.metadata = metadata;
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
                .With(m => m.Role)
                .With(m => m.Metadata)
                .Equals();
        }
        /// <summary>Hash function</summary>
        /// <returns>A hash code for the current object</returns>
        public override int GetHashCode()
        {
             return new HashCodeBuilder<PropertyInfo>(this)
                .With(m => m.Name)
                .With(m => m.Type)
                .With(m => m.Role)
                .With(m => m.Metadata)
                .HashCode;
        }
    }
    
}
