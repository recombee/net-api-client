using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Recombee.ApiClient.Bindings
{
    /// <summary>Binding encapsulating responses to a batch request</summary>
    public class BatchResponse: RecombeeBinding
    {
        private readonly IEnumerable<object> responses;

        public IEnumerable<object> Responses
        {
            get {return responses;}
        }

        private readonly IEnumerable<HttpStatusCode> statusCodes;

        public IEnumerable<HttpStatusCode> StatusCodes
        {
            get {return statusCodes;}
        }

        /// <summary>Get i-th reponse. If the sub-request failed, throws the appropriate exception.</summary>
        public object this[int index]
        {
            get
            {
                var res = responses.ElementAt(index);
                if(res is Exception)
                    throw (Exception)res;
                return res;
            }
        }

        public BatchResponse(IEnumerable<object> responses, IEnumerable<HttpStatusCode> statusCodes)
        {
            this.responses = responses;
            this.statusCodes = statusCodes;
        }
    }
}
