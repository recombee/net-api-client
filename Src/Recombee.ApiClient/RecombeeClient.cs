using System;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Threading.Tasks;
using System.Threading;
using Nito.AsyncEx.Synchronous;
using Recombee.ApiClient.ApiRequests;
using Recombee.ApiClient.Bindings;
using Recombee.ApiClient.Util;


namespace Recombee.ApiClient
{
    /// <summary>Client for sending requests to Recombee and getting replies</summary>
    public partial class RecombeeClient
    {
        readonly string databaseId;
        readonly byte[] secretTokenBytes;

        readonly bool useHttpsAsDefault;

        readonly string hostUri;
        readonly int? port = null;

        readonly int BATCH_MAX_SIZE = 10000; //Maximal number of requests within one batch request

        HttpClient httpClient;


        /// <summary>Initialize the client</summary>
        /// <param name="databaseId">ID of the database.</param>
        /// <param name="secretToken">Corresponding secret token.</param>
        /// <param name="useHttpsAsDefault">If true, all requests are sent using HTTPS</param>
        /// <param name="baseUri">Custom URI of the recommendation API</param>
        /// <param name="port">Custom port of the recommendation API</param>
        /// <param name="region">region of the Recombee cluster where the database is located</param>
        public RecombeeClient(string databaseId, string secretToken, bool useHttpsAsDefault = true,
                              string baseUri = null, int? port = null, Region? region = null)
        {
            this.databaseId = databaseId;
            this.secretTokenBytes = Encoding.ASCII.GetBytes(secretToken);
            this.useHttpsAsDefault = useHttpsAsDefault;
            this.httpClient = createHttpClient();
            this.hostUri = getHostUri(baseUri, region);
            this.port = port;
        }

        private string getRegionalBaseUri(Region? region) {
            switch (region) {
                case Region.ApSe:
                    return "rapi-ap-se.recombee.com";
                case Region.CaEast:
                    return "rapi-ca-east.recombee.com";
                case Region.EuWest:
                    return "rapi-eu-west.recombee.com";
                case Region.UsWest:
                    return "rapi-us-west.recombee.com";
                default:
                    throw new ArgumentException("Unknown region given");
            }
        }

        private string getHostUri(string baseUri, Region? region) {
            string hostUri = null;

            var envHostUri = Environment.GetEnvironmentVariable("RAPI_URI");
            if (envHostUri != null)
                hostUri = envHostUri;
            else
                hostUri = baseUri;

            if (region != null) {
                if (hostUri != null) {
                    throw new ArgumentException("baseUri and region cannot be specified at the same time");
                }
                hostUri = getRegionalBaseUri(region);
            }

            if (hostUri == null) {
                hostUri = "rapi.recombee.com";
            }

            return hostUri;
        }

        private HttpClient createHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "recombee-.net-api-client/4.1.0");
            return httpClient;
        }

        private void RaiseExceptionOnFault(Task task)
        {
            try
            {
                task.Wait();
            }
            catch(AggregateException ae)
            {
                throw ae.Flatten().InnerException;
            }
        }

        public async Task<StringBinding> SendAsync(Request request)
        {
            var json = await SendRequestAsync(request).ConfigureAwait(false);
            return ParseResponse(json, request);
        }

        public StringBinding Send(Request request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }

        public StringBinding ParseResponse(string json, Request request)
        {
            return new StringBinding(json);
        }

        public async Task<IEnumerable<Item>> SendAsync(ListItems request)
        {
            var json = await SendRequestAsync(request).ConfigureAwait(false);
            return ParseResponse(json, request);
        }

        public IEnumerable<Item> Send(ListItems request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }

        public async Task<IEnumerable<User>> SendAsync(ListUsers request)
        {
            var json = await SendRequestAsync(request).ConfigureAwait(false);
            return ParseResponse(json, request);
        }

        public IEnumerable<User> Send(ListUsers request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }

        private IEnumerable<Recommendation> ParseRecommRequestResponse(string json, Request request)
        {
            try
            {
                var strArray = JsonConvert.DeserializeObject<string[]>(json);
                return strArray.Select(x => new Recommendation(x));
            }
            catch(Newtonsoft.Json.JsonReaderException)
            {
                //might have failed because it returned also the item properties
                var valsArray = JsonConvert.DeserializeObject<Dictionary<string, object>[]>(json);
                return valsArray.Select(vals => new Recommendation((string)vals["itemId"], vals));
            }
        }

        private IEnumerable<Item> ParseResponse(string json, ListItems request)
        {
            try
            {
                var strArray = JsonConvert.DeserializeObject<string[]>(json);
                return strArray.Select(x => new Item(x));
            }
            catch(Newtonsoft.Json.JsonReaderException)
            {
                //might have failed because it returned also the item properties
                var valsArray = JsonConvert.DeserializeObject<Dictionary<string, object>[]>(json);
                return valsArray.Select(vals => new Item((string)vals["itemId"], vals));
            }
        }

        private IEnumerable<User> ParseResponse(string json, ListUsers request)
        {
            try
            {
                var strArray = JsonConvert.DeserializeObject<string[]>(json);
                return strArray.Select(x => new User(x));
            }
            catch(Newtonsoft.Json.JsonReaderException)
            {
                //might have failed because it returned also the item properties
                var valsArray = JsonConvert.DeserializeObject<Dictionary<string, object>[]>(json);
                return valsArray.Select(vals => new User((string)vals["userId"], vals));
            }
        }

        public async Task<Item> SendAsync(GetItemValues request)
        {
            var json = await SendRequestAsync(request).ConfigureAwait(false);
            return ParseResponse(json, request);
        }

        public Item Send(GetItemValues request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }

        private Item ParseResponse(string json, GetItemValues request)
        {
            var vals = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            return new Item(request.ItemId, vals);
        }

        public async Task<User> SendAsync(GetUserValues request)
        {
            var json = await SendRequestAsync(request).ConfigureAwait(false);
            return ParseResponse(json, request);
        }

        public User Send(GetUserValues request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }

        private User ParseResponse(string json, GetUserValues request)
        {
            var vals = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            return new User(request.UserId, vals);
        }

        private class BatchParseHelper
        {
            public int code;
            public Newtonsoft.Json.Linq.JRaw json;
            
            public BatchParseHelper()
            {
                code = 0;
                json = null;
            }
        }
        
        public async Task<BatchResponse> SendAsync(Batch request)
        {
            if(request.Requests.Count() > BATCH_MAX_SIZE )
                return await SendMultipartBatchRequestAsync(request).ConfigureAwait(false);

            var json = await SendRequestAsync(request);
            var partiallyParsed = JsonConvert.DeserializeObject<BatchParseHelper[]>(json);

            var resps = request.Requests.Zip(partiallyParsed, (req, res) => (object) ParseOneBatchResponse(res.json.ToString(), res.code, req));
            var statusCodes = partiallyParsed.Select(res => (HttpStatusCode) res.code);
            return new BatchResponse(resps, statusCodes);
        }

        public BatchResponse Send(Batch request)
        {
            var task = Task.Run(async () => await SendAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }

        private async Task<BatchResponse> SendMultipartBatchRequestAsync(Batch request)
        {
            var parts = request.Requests.Part(BATCH_MAX_SIZE);
            var results = new List<BatchResponse>();
            foreach(var part in parts)
            {
                // The parts of a single Batch must be processed after one another in the original order due to possible data dependencies
                results.Add(await SendAsync(new Batch(part)).ConfigureAwait(false));
            }
            var responses = results.Select(br => br.Responses).SelectMany(x => x);
            var statusCodes = results.Select(br => br.StatusCodes).SelectMany(x => x);
            return new BatchResponse(responses, statusCodes);
        }

        protected async Task<string> SendRequestAsync(Request request)
        {
            var uri = ProcessRequestUri(request);
            try
            {
                var response = await PerformHttpRequestAsync(uri, request).ConfigureAwait(false);
                var jsonString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                CheckStatusCode(response.StatusCode, jsonString, request);
                return jsonString;
            }
            catch (TaskCanceledException e)
            {
                throw new TimeoutException(request, e);
            }
        }

        protected string SendRequest(Request request)
        {
            var task = Task.Run(async () => await SendRequestAsync(request));
            var result = task.WaitAndUnwrapException();
            return result;
        }

        private void CheckStatusCode(System.Net.HttpStatusCode statusCode, string response, Request request)
        {
            int code = (int) statusCode;
            if(code>=200 && code <=299)
                return;
                
            throw new ResponseException(request, statusCode, response);
        }


        private async Task<HttpResponseMessage> PerformHttpRequestAsync(string uri, Request request)
        {
            // https://github.com/davidfowl/AspNetCoreDiagnosticScenarios/blob/93e39b8f48169cce4803615519ef87bb2a969c8e/AsyncGuidance.md#always-dispose-cancellationtokensources-used-for-timeouts
            using (var ctsTimeout = new CancellationTokenSource(request.Timeout))
            {
                try{
                    if (request.RequestHttpMehod == HttpMethod.Get)
                    {
                        return await httpClient.GetAsync(uri, ctsTimeout.Token);
                    }
                    else if (request.RequestHttpMehod == HttpMethod.Put)
                    {
                        string bodyParams = JsonConvert.SerializeObject(request.BodyParameters());
                        return await httpClient.PutAsync(uri, new StringContent(bodyParams, Encoding.UTF8,"application/json"), ctsTimeout.Token);
                    }
                    else if (request.RequestHttpMehod == HttpMethod.Post)
                    {
                        string bodyParams = JsonConvert.SerializeObject(request.BodyParameters());
                        return await httpClient.PostAsync(uri, new StringContent(bodyParams, Encoding.UTF8,"application/json"), ctsTimeout.Token);
                    }
                    else if (request.RequestHttpMehod == HttpMethod.Delete)
                    {
                        string bodyParams = JsonConvert.SerializeObject(request.BodyParameters());

                        var requestMessage = new HttpRequestMessage {
                            Method = HttpMethod.Delete,
                            RequestUri = new Uri(uri),
                            Content = new StringContent(bodyParams, Encoding.UTF8,"application/json")
                        };
                        return await httpClient.SendAsync(requestMessage, ctsTimeout.Token);
                    }
                    else
                    {
                        throw new InvalidOperationException("Unknown method " + request.RequestHttpMehod.ToString());
                    }
                }
                catch (TaskCanceledException ex)
                {
                    throw new TimeoutException(request, ex);
                }
            }
        }

        private string StripLeadingQuestionMark(string query)
        {
            if (query.Length > 0 && query[0] == '?')
            {
                return query.Substring(1);
            }
            return query;
        }

        private string ProcessRequestUri(Request request)
        {
            var uriBuilder = new UriBuilder();
            uriBuilder.Path = string.Format("/{0}{1}",databaseId,request.Path());
            uriBuilder.Query = QueryParameters(request);
            AppendHmacParameters(uriBuilder);
            uriBuilder.Scheme = (request.EnsureHttps || useHttpsAsDefault) ? "https" : "http";
            uriBuilder.Host = hostUri;
            if (this.port.HasValue)
                uriBuilder.Port = this.port.Value;
            return uriBuilder.ToString();
        }

        private string QueryParameters(Request request)
        {            
            var encodedQueryStringParams = request.QueryParameters().
                Select (p => string.Format("{0}={1}", p.Key, WebUtility.UrlEncode(String.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}", p.Value))));
            return string.Join("&", encodedQueryStringParams);
        }

        private Int32 UnixTimestampNow() 
        {
            return (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }
        private void AppendHmacParameters(UriBuilder uriBuilder)
        {
            uriBuilder.Query = StripLeadingQuestionMark(uriBuilder.Query) + (uriBuilder.Query.Length == 0 ? "" : "&") + string.Format("hmac_timestamp={0}",this.UnixTimestampNow());
            using(var myhmacsha1 = new HMACSHA1(this.secretTokenBytes))
            {
                var uriToBeSigned = uriBuilder.Path + uriBuilder.Query;
                byte[] hmacBytes = myhmacsha1.ComputeHash(Encoding.ASCII.GetBytes(uriToBeSigned));
                string hmacRes = BitConverter.ToString(hmacBytes).Replace("-","");
                uriBuilder.Query = StripLeadingQuestionMark(uriBuilder.Query) + string.Format("&hmac_sign={0}",hmacRes);
            }
        }
    }
}
