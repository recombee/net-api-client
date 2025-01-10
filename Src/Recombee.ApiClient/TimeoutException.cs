using System;
using Recombee.ApiClient.ApiRequests;

namespace Recombee.ApiClient
{
    /// <summary>Exception thrown when a request is not processed within the timeout</summary>
    public class TimeoutException: ApiException
    {
        private Request request;
        
        /// <summary>Request that timed out</summary>
        public Request TimedOutRequest{
            get {return request;}
        }

        /// <summary>Create the exception</summary>
        /// <param name="request">Request which caused the exception</param>
        /// <param name="innner">Exception from underlying HTTP library</param>
        public TimeoutException(Request request, Exception innner): base(string.Format("Client did not get response within {0} ms", request.Timeout.TotalMilliseconds), innner)
        {
            this.request = request;
        }
    }
}
