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
        private readonly Dictionary<string, object> reqlEvaluations;

        /// <summary>Property values of the recommended item</summary>
        public Dictionary<string, object> Values
        {
            get
            {
                if(values == null)
                    throw new InvalidOperationException("Getting values is possible only if the optional parameter returnProperties of the recommendation request is set to true");
                return values;
            }
        }

        /// <summary>Evaluations of ReQL expressions for the recommended item</summary>
        public Dictionary<string, object> ReqlEvaluations
        {
            get
            {
                if(reqlEvaluations == null)
                    throw new InvalidOperationException("Getting ReQL evaluations is possible only if some reqlExpressions were specified in the recommendation request");
                return reqlEvaluations;
            }
        }

        public Recommendation (string id, Dictionary<string, object> values = null, Dictionary<string, object> reqlEvaluations = null) {
            this.id = id;
            this.values = values;
            this.reqlEvaluations = reqlEvaluations;
        }
    
    }
    
}
