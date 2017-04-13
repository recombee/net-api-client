using System;
using System.Collections.Generic;
using System.Net.Http;


namespace Recombee.ApiClient.ApiRequests
{
    /// <summary>Set/update (some) property values of a given item</summary>
    /// <remarks>The properties (columns) must be previously created by Add item property(https://docs.recombee.com/api.html#add-item-property).</remarks>
    public class SetItemValues : SetValues
    {
        private readonly string itemId;
        
        /// <summary>ID of the item which will be modified.</summary> 
        public string ItemId
        {
            get {return itemId;}
        }

        /// <summary>Construct the request</summary>
        /// <param name="itemId">ID of the item which will be modified.</param>
        /// <param name="values">The values for the individual properties. Key in the Dictionary is the name of the property and value is the value to be set.</param>
        /// <param name="cascadeCreate">Sets whether the item should be created if not present in the database.</param>
        public SetItemValues (string itemId, Dictionary<string, object>  values, bool? cascadeCreate = null): base(values, cascadeCreate)
        {
            this.itemId = itemId;
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return string.Format("/items/{0}", ItemId);
        }
    }
}
