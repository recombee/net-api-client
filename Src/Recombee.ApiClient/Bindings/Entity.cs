using System;
using System.Collections.Generic;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>Base class for the entities</summary>
    public class Entity: RecombeeBinding
    {
        private readonly Dictionary<string, object> values;
        
        /// <summary>Values of properties</summary>
        public Dictionary<string, object> Values
        {
            get
            {
                if(values == null)
                    throw new InvalidOperationException("The request was not meant to return values");
                return values;
            }
        }

        public Entity(Dictionary<string, object> values)
        {
            this.values = values;
        }
    }
}