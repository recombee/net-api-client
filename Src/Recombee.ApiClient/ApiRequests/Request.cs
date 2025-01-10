using System;
using System.Collections.Generic;
using System.Net.Http;


namespace Recombee.ApiClient.ApiRequests
{
    /// <summary>Base class for all the requests</summary>
    public abstract class Request
    {
        private TimeSpan timeout;
        /// <summary>Timeout for the request in milliseconds</summary>
        public TimeSpan Timeout {
            get {return timeout;}
            set {timeout = value;}
        }

        private readonly bool ensureHttps;
        /// <summary>If true, HTTPS must be chosen over HTTP for this request</summary>
         public bool EnsureHttps {
            get {return ensureHttps;}
        }


        private readonly HttpMethod httpMethod;
        /// <summary>Used HTTP method</summary>
        public HttpMethod RequestHttpMehod
        {
            get {
                return httpMethod;
            }
        }


        /// <summary>Construct the request</summary>
        /// <param name="httpMethod">Used HTTP method.</param>
        /// <param name="timeoutMilliseconds">Timeout for the request in milliseconds.</param>
        /// <param name="ensureHttps">If true, HTTPS must be chosen over HTTP for this request</param>
        public Request(HttpMethod httpMethod, int timeoutMilliseconds, bool ensureHttps = false)
        {
            this.httpMethod = httpMethod;
            Timeout = new TimeSpan(0,0,0,0, timeoutMilliseconds);
            this.ensureHttps = ensureHttps;
        }

        /// <returns>URI to the endpoint including path parameters</returns>
        public abstract string Path();

        /// <summary>Get body parameters</summary>
        /// <returns>Dictionary containing  values of body parameters (name of parameter: value of the parameter)</returns>
        public abstract Dictionary<string, object> BodyParameters();

        /// <summary>Get query parameters</summary>
        /// <returns>Dictionary containing values of query parameters (name of parameter: value of the parameter)</returns>
        public abstract Dictionary<string, object> QueryParameters();

        /// <returns>Converts DateTime to UNIX timestamp (epoch)</returns>
        protected double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }

    }
}
