using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>Binding of one recommended item</summary>
    public class Recommendation: RecombeeBinding {

        private readonly string id;

        /// <summary>Id of the recommended item</summary>
        public string Id
        {
            get {return id;}
        }

        private readonly Dictionary<string, object> values;

        /// <summary>Property values of the recommended item</summary>
        public Dictionary<string, object> Values
        {
            get
            {
                if(values == null)
                    throw new InvalidOperationException("Getting values is possible only if the optional parameter returnProperties of the recommendation request is set to true)");
                return values;
            }
        }
    
        public Recommendation (string id, Dictionary<string, object> values = null) {
            this.id = id;
            this.values = values;
        }
    
    }
    
}
