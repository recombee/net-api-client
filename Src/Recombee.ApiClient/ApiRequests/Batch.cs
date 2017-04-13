using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;

namespace Recombee.ApiClient.ApiRequests
{
    /// <summary>Batch request for submitting multiple atomic requests.</summary>
    /// <remarks>
    /// In many cases, it may be desirable to execute multiple requests at once. For example, when synchronizing the catalog of items in periodical manner, you would have to execute a sequence of thousands of separate POST requests, which is very ineffective and may take a very long time to complete. Most notably, network latencies can make execution of such a sequence very slow and even if executed in multiple parallel threads, there will still be unreasonable overhead caused by the HTTP(s). To avoid the problems mentioned, batch processing may be used, encapsulating a sequence of requests into a single HTTP request.
    /// Batch processing allows you to submit arbitrary sequence of requests in form of JSON array. Any type of request from the above documentation may be used in the batch, and the batch may combine different types of requests arbitrarily as well.
    /// Note that:
    /// - executing the requests in a batch is equivalent as if they were executed one-by-one individually; there are, however, many optimizations to make batch execution as fast as possible,
    /// - the status code of the batch request itself is 200 even if the individual requests result in error – you have to inspect the code values in the resulting array,
    /// - if the status code of the whole batch is not 200, then there is an error in the batch request itself; in such a case, the error message returned should help you to resolve the problem,
    /// - currently, batch size is limited to **10,000** requests; if you wish to execute even larger number of requests, please split the batch into multiple parts.
    /// </remarks>
    public class Batch: Request
    {
        private readonly IEnumerable<Request> requests;

        ///<summary>JSON array containing the requests.</summary>
        public IEnumerable<Request> Requests
        {
            get {return requests;}
        }
        private readonly bool? distinctRecomms;

        /// <summary>Makes all the recommended items for a certain user distinct among multiple recommendation requests in the batch.</summary>
        public bool? DistinctRecomms
        {
            get {return distinctRecomms;}
        }
    

        /// <summary>Construct the request</summary>
        /// <param name="requests">IEnumerable containing the requests.</param>
        /// <param name="distinctRecomms">Makes all the recommended items for a certain user distinct among multiple recommendation requests in the batch.</param>
        public Batch (IEnumerable<Request> requests, bool? distinctRecomms = null): base(HttpMethod.Post, sumTimeouts(requests), true)
        {
            this.requests = requests;
            this.distinctRecomms = distinctRecomms;
        }

        private static int sumTimeouts(IEnumerable<Request> requests)
        {
            return requests.Select(x => (int) x.Timeout.TotalMilliseconds).Sum();
        }
    
        /// <returns>URI to the endpoint including path parameters</returns>
        public override string Path()
        {
            return "/batch/";
        }
    
        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> QueryParameters()
        {
           return new Dictionary<string, object>();
        }
    
        /// <summary>Get body parameters</summary>
        /// <returns>Dictionary containing  values of body parameters (name of parameter: value of the parameter)</returns>
        public override Dictionary<string, object> BodyParameters()
        {
            var requestsDicts = requests.Select(r => requestToBatchDictionary(r));
            var result = new Dictionary<string, object>()
            {
                {"requests", requestsDicts}
            };
            if(DistinctRecomms.HasValue)
                result["distinctRecomms"] = DistinctRecomms.Value;
            return result;
        }


        private Dictionary<string, object> requestToBatchDictionary(Request req)
        {
            var bd = new Dictionary<string, object>()
            {
                {"path", req.Path()},
                {"method", req.RequestHttpMehod.ToString()}
            };
            var paramsDict = req.QueryParameters(); 
            req.BodyParameters().ToList().ForEach(x => paramsDict.Add(x.Key, x.Value));
            if (paramsDict.Count > 0)
                bd["params"] = paramsDict;
 
            return bd;
        }
    
    }
}
