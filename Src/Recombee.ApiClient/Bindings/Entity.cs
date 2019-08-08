using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>Base class for the entities</summary>
    public abstract class Entity: RecombeeBinding
    {
        private readonly Dictionary<string, object> values;
        
        /// <summary>Values of properties</summary>
        [JsonProperty("values")]
        public Dictionary<string, object> Values
        {
            get
            {
                if(values == null)
                    throw new InvalidOperationException("The request was not meant to return values (use returnProperties parameter)");
                return values;
            }
        }

        public Entity(Dictionary<string, object> values)
        {
            this.values = values;
        }
    }
}