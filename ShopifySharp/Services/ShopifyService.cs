using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ShopifySharp.Infrastructure;
using Newtonsoft.Json;
using System.IO;
using ShopifySharp.Lists;
using ShopifySharp.Filters;

namespace ShopifySharp
{
    public abstract class ShopifyService
    {
        public virtual string APIVersion => "2019-10";

        private static IRequestExecutionPolicy _GlobalExecutionPolicy = new DefaultRequestExecutionPolicy();

        private IRequestExecutionPolicy _ExecutionPolicy;

        private static JsonSerializer _Serializer = Serializer.JsonSerializer;

        private static HttpClient _Client { get; } = new HttpClient();

        protected Uri _ShopUri { get; set; }

        protected string _AccessToken { get; set; }

        protected virtual bool SupportsAPIVersioning => true;

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        protected ShopifyService(string myShopifyUrl, string shopAccessToken)
        {
            _ShopUri = BuildShopUri(myShopifyUrl, false);
            _AccessToken = shopAccessToken;

            // If there's a global execution policy it should be set as this instance's policy.
            // User can override it with instance-specific execution policy.
            _ExecutionPolicy = _GlobalExecutionPolicy ?? new DefaultRequestExecutionPolicy();
        }

        /// <summary>
        /// Attempts to build a shop API <see cref="Uri"/> for the given shop. Will throw a <see cref="ShopifyException"/> if the URL cannot be formatted.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <exception cref="ShopifyException">Thrown if the given URL cannot be converted into a well-formed URI.</exception>
        /// <returns>The shop's API <see cref="Uri"/>.</returns>
        public static Uri BuildShopUri(string myShopifyUrl, bool withAdminPath)
        {
            if (Uri.IsWellFormedUriString(myShopifyUrl, UriKind.Absolute) == false)
            {
                //Shopify typically returns the shop URL without a scheme. If the user is storing that as-is, the uri will not be well formed.
                //Try to fix that by adding a scheme and checking again.
                if (Uri.IsWellFormedUriString("https://" + myShopifyUrl, UriKind.Absolute) == false)
                {
                    throw new ShopifyException($"The given {nameof(myShopifyUrl)} cannot be converted into a well-formed URI.");
                }

                myShopifyUrl = "https://" + myShopifyUrl;
            }

            var builder = new UriBuilder(myShopifyUrl)
            {
                Scheme = "https:",
                Port = 443, //SSL port
                Path = withAdminPath ? "admin" : ""
            };

            return builder.Uri;
        }

        /// <summary>
        /// Sets the execution policy for this instance only. This policy will always be used over the global execution policy.
        /// The instance will revert back to the global execution policy if you pass null to this method.
        /// </summary>
        public void SetExecutionPolicy(IRequestExecutionPolicy executionPolicy)
        {
            // If the user passes null, revert to the global execution policy.
            _ExecutionPolicy = executionPolicy ?? _GlobalExecutionPolicy ?? new DefaultRequestExecutionPolicy();
        }

        /// <summary>
        /// Sets the global execution policy for all *new* instances. Current instances are unaffected, but you can call .SetExecutionPolicy on them.
        /// </summary>
        public static void SetGlobalExecutionPolicy(IRequestExecutionPolicy globalExecutionPolicy)
        {
            _GlobalExecutionPolicy = globalExecutionPolicy;
        }

        protected RequestUri PrepareRequest(string path)
        {
            var ub = new UriBuilder(_ShopUri)
            {
                Scheme = "https:",
                Port = 443,
                Path = SupportsAPIVersioning ? $"admin/api/{APIVersion}/{path}" : $"admin/{path}"
            };

            return new RequestUri(ub.Uri);
        }

        /// <summary>
        /// Prepares a request to the path and appends the shop's access token header if applicable.
        /// </summary>
        protected CloneableRequestMessage PrepareRequestMessage(RequestUri uri, HttpMethod method, HttpContent content = null)
        {
            var msg = new CloneableRequestMessage(uri.ToUri(), method, content);

            if (!string.IsNullOrEmpty(_AccessToken))
            {
                msg.Headers.Add("X-Shopify-Access-Token", _AccessToken);
            }

            msg.Headers.Add("Accept", "application/json");

            return msg;
        }

        /// <summary>
        /// Attempts to parse the Link header from a web response. Returns either the header value or null if it does not exist.
        /// </summary>
        /// <remarks>
        /// The Link header only exists on list requests. 
        /// </remarks>
        private string ReadLinkHeader(HttpResponseMessage response)
        {
            var linkHeaderValues = response.Headers
                                 .FirstOrDefault(h => h.Key.Equals("link", StringComparison.OrdinalIgnoreCase))
                                 .Value;

            return linkHeaderValues == null ? null : string.Join(", ", linkHeaderValues);
        }

        /// <summary>
        /// Executes a request and returns a JToken for querying. Throws an exception when the response is invalid.
        /// Use this method when the expected response is a single line or simple object that doesn't warrant its own class.
        /// </summary>
        /// <remarks>
        /// This method will automatically dispose the <paramref name="baseClient"/> and <paramref name="content" /> when finished.
        /// </remarks>
        protected async Task<RequestResult<JToken>> ExecuteRequestAsync(RequestUri uri, HttpMethod method, HttpContent content = null)
        {
            using (var baseRequestMessage = PrepareRequestMessage(uri, method, content))
            {
                var policyResult = await _ExecutionPolicy.Run(baseRequestMessage, async (requestMessage) =>
                {
                    var request = _Client.SendAsync(requestMessage);

                    using (var response = await request)
                    {
                        var rawResult = await response.Content.ReadAsStringAsync();

                        //Check for and throw exception when necessary.
                        CheckResponseExceptions(response, rawResult);

                        JToken jtoken = null;

                        // Don't parse the result when the request was Delete.
                        if (baseRequestMessage.Method != HttpMethod.Delete)
                        {
                            // Make sure that dates are not stripped of any timezone information if tokens are de-serialised into strings/DateTime/DateTimeZoneOffset
                            using (var reader = new JsonTextReader(new StringReader(rawResult)) { DateParseHandling = DateParseHandling.None })
                            {
                                jtoken = JObject.Load(reader);
                            }
                        }

                        return new RequestResult<JToken>(response, jtoken, rawResult, ReadLinkHeader(response));
                    }
                });

                return policyResult;
            }
        }

        /// <summary>
        /// Executes a request and returns the given type. Throws an exception when the response is invalid.
        /// Use this method when the expected response is a single line or simple object that doesn't warrant its own class.
        /// </summary>
        /// <remarks>
        /// This method will automatically dispose the <paramref name="baseRequestMessage" /> when finished.
        /// </remarks>
        protected async Task<RequestResult<T>> ExecuteRequestAsync<T>(RequestUri uri, HttpMethod method, HttpContent content = null, string rootElement = null)
        {
            using (var baseRequestMessage = PrepareRequestMessage(uri, method, content))
            {
                var policyResult = await _ExecutionPolicy.Run(baseRequestMessage, async (requestMessage) =>
                {
                    var request = _Client.SendAsync(requestMessage);

                    using (var response = await request)
                    {
                        var rawResult = await response.Content.ReadAsStringAsync();

                        //Check for and throw exception when necessary.
                        CheckResponseExceptions(response, rawResult);

                        T result = default;
                        if (rootElement != null)
                        {
                            // This method may fail when the method was Delete, which is intendend.
                            // Delete methods should not be parsing the response JSON and should instead
                            // be using the non-generic ExecuteRequestAsync.
                            var reader = new JsonTextReader(new StringReader(rawResult));
                            var data = _Serializer.Deserialize<JObject>(reader).SelectToken(rootElement);
                            result = data.ToObject<T>();
                        }

                        return new RequestResult<T>(response, result, rawResult, ReadLinkHeader(response));
                    }
                });

                return policyResult;
            }
        }

        private async Task<T> ExecuteWithContentCoreAsync<T>(string path, string resultRootElt, HttpMethod method, JsonContent content)
        {
            var req = PrepareRequest(path);
            var response = await ExecuteRequestAsync<T>(req, method, content, resultRootElt);
            return response.Result;
        }

        protected async Task<T> ExecutePostAsync<T>(string path, string resultRootElt, object jsonContent = null)
        {
            return await ExecuteWithContentCoreAsync<T>(path, resultRootElt, HttpMethod.Post, jsonContent == null ? null : new JsonContent(jsonContent));
        }

        protected async Task<T> ExecutePutAsync<T>(string path, string resultRootElt, object jsonContent = null)
        {
            return await ExecuteWithContentCoreAsync<T>(path, resultRootElt, HttpMethod.Put, jsonContent == null ? null : new JsonContent(jsonContent));
        }

        protected async Task ExecuteDeleteAsync(string path)
        {
            await ExecuteWithContentCoreAsync<JToken>(path, null, HttpMethod.Delete, null);
        }

        private async Task<RequestResult<T>> ExecuteGetCoreAsync<T>(string path, string resultRootElt, Parameterizable queryParams, string fields)
        {
            var req = PrepareRequest(path);

            if (queryParams != null)
            {
                req.QueryParams.AddRange(queryParams.ToQueryParameters());
            }

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<T>(req, HttpMethod.Get, rootElement: resultRootElt);
        }

        protected async Task<T> ExecuteGetAsync<T>(string path, string resultRootElt, string fields)
        {
            return (await ExecuteGetCoreAsync<T>(path, resultRootElt, null, fields)).Result;
        }

        protected async Task<T> ExecuteGetAsync<T>(string path, string resultRootElt, Parameterizable queryParams = null)
        {
            return (await ExecuteGetCoreAsync<T>(path, resultRootElt, queryParams, null)).Result;
        }

        protected async Task<ListResult<T>> ExecuteGetListAsync<T>(string path, string resultRootElt, ListFilter<T> filter)
        {
            var result = await ExecuteGetCoreAsync<List<T>>(path, resultRootElt, filter, null);
            return ParseLinkHeaderToListResult(result);
        }

        /// <summary>
        /// Checks a response for exceptions or invalid status codes. Throws an exception when necessary.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <<param name="rawResponse">The response body returned by Shopify.</param>
        public static void CheckResponseExceptions(HttpResponseMessage response, string rawResponse)
        {
            var statusCode = (int)response.StatusCode;

            // No error if response was between 200 and 300.
            if (statusCode >= 200 && statusCode < 300)
            {
                return;
            }

            var requestIdHeader = response.Headers.FirstOrDefault(h => h.Key.Equals("X-Request-Id", StringComparison.OrdinalIgnoreCase));
            var requestId = requestIdHeader.Value?.FirstOrDefault();
            var code = response.StatusCode;
            var statusMessage = $"{(int)code} {response.ReasonPhrase}";

            // If the error was caused by reaching the API rate limit, throw a rate limit exception.
            if ((int)code == 429 /* Too many requests */)
            {
                string rateExceptionMessage;
                IEnumerable<string> errors;
                
                if (TryParseErrorJson(rawResponse, out var rateLimitErrors))
                {
                    rateExceptionMessage = $"({statusMessage}) {rateLimitErrors.First()}";
                    errors = rateLimitErrors;
                }
                else
                {
                    var baseMessage = "Exceeded the rate limit for api client. Reduce request rates to resume uninterrupted service.";
                    rateExceptionMessage = $"({statusMessage}) {baseMessage}";
                    errors = new List<string>{ baseMessage };
                }

                throw new ShopifyRateLimitException(code, errors, rateExceptionMessage, rawResponse, requestId);
            }

            var contentType = response.Content.Headers.GetValues("Content-Type").FirstOrDefault();

            if (contentType.StartsWithIgnoreCase("application/json") || contentType.StartsWithIgnoreCase("text/json"))
            {
                IEnumerable<string> errors;
                string exceptionMessage;

                if (TryParseErrorJson(rawResponse, out var parsedErrors))
                {
                    var firstError = parsedErrors.First();
                    var totalErrors = parsedErrors.Count();
                    var baseErrorMessage = $"({statusMessage}) {firstError}";

                    switch (totalErrors)
                    {
                        case 1 :
                            exceptionMessage = baseErrorMessage;
                            break;
                        
                        case 2:
                            exceptionMessage = $"{baseErrorMessage} (and one other error)";
                            break;
                        
                        default:
                            exceptionMessage = $"{baseErrorMessage} (and {totalErrors} other errors)";
                            break;
                    }
                    
                    errors = parsedErrors;
                }
                else
                {
                    exceptionMessage = $"({statusMessage}) Shopify returned {statusMessage}, but ShopifySharp was unable to parse the response JSON.";
                    errors = new List<string>
                    {
                        exceptionMessage
                    };
                }

                throw new ShopifyException(code, errors, exceptionMessage, rawResponse, requestId);
            }

            var message = $"({statusMessage}) Shopify returned {statusMessage}, but there was no JSON to parse into an error message.";
            var customErrors = new List<string>
            {
                message
            };

            throw new ShopifyException(code, customErrors, message, rawResponse, requestId);
        }

        /// <summary>
        /// Attempts to parse a JSON string for Shopify API errors. Returns false if the string cannot be parsed or contains no errors. 
        /// </summary>
        public static bool TryParseErrorJson(string json, out List<string> output)
        {
            output = null;
            
            if (string.IsNullOrEmpty(json))
            {
                return false;
            }

            var errors = new List<string>();

            try
            {
                var parsed = JToken.Parse(string.IsNullOrEmpty(json) ? "{}" : json);

                if (parsed.Type != JTokenType.Object)
                {
                    return false;
                }

                // Errors can be any of the following:
                // 1. { "errors": "some error message"}
                // 2. { "errors": { "order" : "some error message" } }
                // 3. { "errors": { "order" : [ "some error message" ] } }
                // 4. { "error": "invalid_request", error_description:"The authorization code was not found or was already used" }
                // 5. { "error": "location_id must be specified when creating fulfillments." }

                if (parsed.Any(p => p.Path == "error") && parsed.Any(p => p.Path == "error_description"))
                {
                    // Error is type #4
                    var description = parsed["error_description"].Value<string>();
                    var errorType = parsed["error"].Value<string>();
                    
                    errors.Add($"{errorType}: {description}");
                }
                else if (parsed.Any(p => p.Path == "error"))
                {
                    // Error is type #5
                    var description = parsed["error"].Value<string>();
                    
                    errors.Add(description);
                }
                else if (parsed.Any(x => x.Path == "errors"))
                {
                    var parsedErrors = parsed["errors"];

                    // errors can be either a single string, or an array of other errors
                    if (parsedErrors.Type == JTokenType.String)
                    {
                        // errors is type #1
                        var description = parsedErrors.Value<string>();

                        errors.Add(description);
                    }
                    else
                    {
                        // errors is type #2 or #3
                        foreach (var val in parsedErrors.Values())
                        {
                            var name = val.Path.Split('.').Last();

                            if (val.Type == JTokenType.String)
                            {
                                var description = val.Value<string>();
                                
                                errors.Add($"{name}: {description}");
                            }
                            else if (val.Type == JTokenType.Array)
                            {
                                foreach (var msg in val.Values<string>())
                                {
                                    errors.Add($"{name}: {msg}");
                                }
                            }
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (JsonReaderException)
            {
                return false;
            }

            if (!errors.Any())
            {
                return false;
            }

            output = errors;
            
            return true;
        }

        /// <summary>
        /// Parses a link header value into a ListResult<T>. The Items property will need to be manually set. 
        /// </summary>
        protected ListResult<T> ParseLinkHeaderToListResult<T>(RequestResult<List<T>> requestResult)
        {
            return new ListResult<T>(requestResult.Result, requestResult.RawLinkHeaderValue == null ? null : LinkHeaderParser.Parse<T>(requestResult.RawLinkHeaderValue));
        }
    }
}
