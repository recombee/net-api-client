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
        /// * `int`- Signed integer number.
        /// * `double` - Floating point number. It uses 64-bit base-2 format (IEEE 754 standard).
        /// * `string` - UTF-8 string.
        /// * `boolean` - *true* / *false*
        /// * `timestamp` - Value representing date and time.
        /// * `set` - Set of strings.
        /// * `image` - URL of an image (`jpeg`, `png` or `gif`).
        /// * `imageList` - List of URLs that refer to images. 
        /// </summary>
        public string Type
        {
            get {return type;}
        }
    
        /// <summary>Construct the request</summary>
        /// <param name="propertyName">Name of the item property to be created. Currently, the following names are reserved: `id`, `itemid`, case-insensitively. Also, the length of the property name must not exceed 63 characters.
        /// </param>
        /// <param name="type">Value type of the item property to be created. One of: `int`, `double`, `string`, `boolean`, `timestamp`, `set`, `image` or `imageList`.
        /// * `int`- Signed integer number.
        /// * `double` - Floating point number. It uses 64-bit base-2 format (IEEE 754 standard).
        /// * `string` - UTF-8 string.
        /// * `boolean` - *true* / *false*
        /// * `timestamp` - Value representing date and time.
        /// * `set` - Set of strings.
        /// * `image` - URL of an image (`jpeg`, `png` or `gif`).
        /// * `imageList` - List of URLs that refer to images. 
        /// </param>
        public AddItemProperty (string propertyName, string type): base(HttpMethod.Put, 100000)
        {
            this.propertyName = propertyName;
            this.type = type;
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
                {"type", this.Type}
            };
            return parameters;
        }
    
        /// <summary>Get body parameters</summary>
        /// <returns>Dictionary containing  values of body parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> BodyParameters()
        {
           var parameters =  new Dictionary<string, object>()
            {
        
            };
            return parameters;
        }
    
    }
}
