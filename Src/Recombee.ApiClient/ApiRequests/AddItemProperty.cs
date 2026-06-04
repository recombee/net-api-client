/*
 This file is auto-generated, do not edit
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using Recombee.ApiClient.Bindings;
using Recombee.ApiClient.Util;


namespace Recombee.ApiClient.ApiRequests
{
    /// <summary>Add Item Property</summary>
    /// <remarks>Adding an item property is somewhat equivalent to adding a column to the table of items. The items may be characterized by various properties of different types.
    /// </remarks>
    public class AddItemProperty : Request
    {
        private readonly string propertyName;
        /// <summary>Name of the item property to be created. Currently, the following names are reserved: `id`, `itemid`, case-insensitively. Also, the length of the property name must not exceed 63 characters.
        /// </summary>
        public string PropertyName
        {
            get {return propertyName;}
        }
        private readonly string type;
        /// <summary>Value type of the item property to be created. One of: `int`, `double`, `string`, `boolean`, `timestamp`, `set`, `image` or `imageList`.
        /// * `int` - Signed integer number.
        /// * `double` - Floating point number. It uses 64-bit base-2 format (IEEE 754 standard).
        /// * `string` - UTF-8 string.
        /// * `boolean` - *true* / *false*
        /// * `timestamp` - Value representing date and time. ISO8601-1 pattern (string) or UTC epoch time (number).
        /// * `set` - Set of strings.
        /// * `image` - URL of an image (`jpeg`, `png` or `gif`).
        /// * `imageList` - List of URLs that refer to images.
        /// </summary>
        public string Type
        {
            get {return type;}
        }
        private readonly PropertyRole role;
        /// <summary>[Role](https://docs.recombee.com/api/property_roles_metadata#roles) to assign to the property.
        /// </summary>
        public PropertyRole Role
        {
            get {return role;}
        }
        private readonly PropertyMetadata[] metadata;
        /// <summary>List of [metadata](https://docs.recombee.com/api/property_roles_metadata#metadata) entries to assign to the property.</summary>
        public PropertyMetadata[] Metadata
        {
            get {return metadata;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="propertyName">Name of the item property to be created. Currently, the following names are reserved: `id`, `itemid`, case-insensitively. Also, the length of the property name must not exceed 63 characters.
        /// </param>
        /// <param name="type">Value type of the item property to be created. One of: `int`, `double`, `string`, `boolean`, `timestamp`, `set`, `image` or `imageList`.
        /// * `int` - Signed integer number.
        /// * `double` - Floating point number. It uses 64-bit base-2 format (IEEE 754 standard).
        /// * `string` - UTF-8 string.
        /// * `boolean` - *true* / *false*
        /// * `timestamp` - Value representing date and time. ISO8601-1 pattern (string) or UTC epoch time (number).
        /// * `set` - Set of strings.
        /// * `image` - URL of an image (`jpeg`, `png` or `gif`).
        /// * `imageList` - List of URLs that refer to images.
        /// </param>
        /// <param name="role">[Role](https://docs.recombee.com/api/property_roles_metadata#roles) to assign to the property.
        /// </param>
        /// <param name="metadata">List of [metadata](https://docs.recombee.com/api/property_roles_metadata#metadata) entries to assign to the property.</param>
        public AddItemProperty (string propertyName, string type, PropertyRole role = null, PropertyMetadata[] metadata = null): base(HttpMethod.Put, 100000)
        {
            this.propertyName = propertyName;
            this.type = type;
            this.role = role;
            this.metadata = metadata;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/items/properties/{0}", PropertyName);
        }
    
        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> QueryParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
        
            };
            return parameters;
        }
    
        /// <summary>Get body parameters</summary>
        /// <returns>Dictionary containing  values of body parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> BodyParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
                {"type", this.Type}
            };
            if (this.Role != null)
                parameters["role"] = this.Role;
            if (this.Metadata != null)
                parameters["metadata"] = string.Join<PropertyMetadata>(",", this.Metadata);
            return parameters;
        }
    
    }
}
