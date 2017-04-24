using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Newtonsoft.Json.Linq;

namespace ShopifySharp
{
    public abstract class ShopifyService
    {
        private static IRequestExecutionPolicy _ExecutionPolicy = new DefaultRequestExecutionPolicy();

        protected Uri _ShopUri { get; set; }

        protected string _AccessToken { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        protected ShopifyService(string myShopifyUrl, string shopAccessToken)
        {
            _ShopUri = BuildShopUri(myShopifyUrl);
            _AccessToken = shopAccessToken;

            // TODO: If there's a global execution policy set, assign it here.
        }

        /// <summary>
        /// Attempts to build a shop API <see cref="Uri"/> for the given shop. Will throw a <see cref="ShopifyException"/> if the URL cannot be formatted.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <exception cref="ShopifyException">Thrown if the given URL cannot be converted into a well-formed URI.</exception>
        /// <returns>The shop's API <see cref="Uri"/>.</returns>
        public static Uri BuildShopUri(string myShopifyUrl)
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
                Path = "admin/",
                Scheme = "https:",
                Port = 443 //SSL port
            };

            return builder.Uri;
        }

        /// <summary>
        /// Sets the execution policy for this instance only.
        /// </summary>
        public void SetExecutionPolicy(IRequestExecutionPolicy executionPolicy)
        {
            _ExecutionPolicy = executionPolicy;
        }

        /// <summary>
        /// Prepares a request to the path and appends the shop's access token header if applicable.    
        /// </summary>
        protected IFlurlClient PrepareRequest(string path)
        {
            var client = Flurl.Url.Combine(_ShopUri.ToString(), path).AllowAnyHttpStatus();

            if (! string.IsNullOrEmpty(_AccessToken))
            {
                client = client.WithHeader("X-Shopify-Access-Token", _AccessToken);
            }

            return client;
        }

        /// <summary>
        /// Executes a request and returns a JToken for querying. Throws an exception when the response is invalid. 
        /// Use this method when the expected response is a single line or simple object that doesn't warrant its own class.
        /// </summary>
        protected async Task<JToken> ExecuteRequestAsync(IFlurlClient baseClient, HttpMethod method, HttpContent baseContent = null)
        {
            return await _ExecutionPolicy.Run(baseClient, baseContent, async (client, content) =>
            {
                var request = client.SendAsync(method, content);
                var response = await request;
                var rawResult = await request.ReceiveString();

                //Check for and throw exception when necessary.
                CheckResponseExceptions(response, rawResult);

                var jtoken = JToken.Parse(rawResult);

                return new RequestResult<JToken>(response, jtoken, rawResult);
            });
        }

        /// <summary>
        /// Executes a request and returns the given type. Throws an exception when the response is invalid.
        /// Use this method when the expected response is a single line or simple object that doesn't warrant its own class.
        /// </summary>
        /// <param name="baseClient">
        /// The request to be executed. Note that this request will be automatically disposed when the method returns.
        /// </param>
        /// <param name="method">
        /// HTTP method to be used by the request.
        /// </param>
        /// <param name="baseContent">
        /// Content that gets appended to the request body. Can be null. In most cases, you'll want to use <see cref="JsonContent"/>.
        /// </param>
        /// <remarks>
        /// This method will automatically dispose the <paramref name="baseClient"/> when finished.
        /// </remarks>
        protected async Task<T> ExecuteRequestAsync<T>(IFlurlClient baseClient, HttpMethod method, HttpContent baseContent = null, string rootElement = null) where T : new()
        {
            return await _ExecutionPolicy.Run<T>(baseClient, baseContent, async (client, content) =>
            {
                var request = client.SendAsync(method, content);
                var response = await request;
                var rawResult = await request.ReceiveString();
                
                //Check for and throw exception when necessary.
                CheckResponseExceptions(response, rawResult);

                var jtoken = JToken.Parse(rawResult);
                T result = jtoken.Value<T>(rootElement);
                
                return new RequestResult<T>(response, result, rawResult);
            });
        }

        /// <summary>
        /// Checks a response for exceptions or invalid status codes. Throws an exception when necessary.
        /// </summary>
        /// <param name="response">The response.</param>
        public static void CheckResponseExceptions(HttpResponseMessage response, string rawResponse)
        {
            if (response.StatusCode != HttpStatusCode.OK && response.StatusCode != HttpStatusCode.Created)
            {
                var errors = ParseErrorJson(rawResponse);
                var code = response.StatusCode;
                var message = $"Response did not indicate success. Status: {(int)code} {response.ReasonPhrase}.";

                if (errors == null)
                {
                    errors = new Dictionary<string, IEnumerable<string>>()
                    {
                        {
                            $"{(int)code} {response.ReasonPhrase}",
                            new string[] { message }
                        },
                    };
                }
                else
                {
                    var firstError = errors.First();

                    message = $"{firstError.Key}: {string.Join(", ", firstError.Value)}";
                }

                // If the error was caused by reaching the API rate limit, throw a rate limit exception.
                if ((int) code == 429 /* Too many requests */)
                {
                    throw new ShopifyRateLimitException(code, errors, message, rawResponse);
                }
                
                throw new ShopifyException(code, errors, message, rawResponse);
            }
        }
        
        /// <summary>
        /// Parses a JSON string for Shopify API errors.
        /// </summary>
        /// <returns>Returns null if the JSON could not be parsed into an error.</returns>
        public static Dictionary<string, IEnumerable<string>> ParseErrorJson(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return null;
            }

            var errors = new Dictionary<string, IEnumerable<string>>();

            try
            {
                var parsed = JToken.Parse(string.IsNullOrEmpty(json) ? "{}" : json);

                // Errors can be any of the following: 
                // 1. { errors: "some error message"}
                // 2. { errors: { "order" : "some error message" } }
                // 3. { errors: { "order" : [ "some error message" ] } }
                // 4. { error: "invalid_request", error_description:"The authorization code was not found or was already used" }

                if (parsed.Any(p => p.Path == "error") && parsed.Any(p => p.Path == "error_description"))
                {
                    // Error is type #4
                    var description = parsed["error_description"];

                    errors.Add("invalid_request", new List<string>() { description.Value<string>() });
                }
                else if (parsed.Any(x => x.Path == "errors"))
                {
                    var parsedErrors = parsed["errors"];
                    
                    //errors can be either a single string, or an array of other errors
                    if (parsedErrors.Type == JTokenType.String)
                    {
                        //errors is type #1

                        errors.Add("Error", new List<string>() { parsedErrors.Value<string>() });
                    }
                    else
                    {
                        //errors is type #2 or #3

                        foreach (var val in parsedErrors.Values())
                        {
                            string name = val.Path.Split('.').Last();
                            var list = new List<string>();

                            if (val.Type == JTokenType.String)
                            {
                                list.Add(val.Value<string>());
                            }
                            else if (val.Type == JTokenType.Array)
                            {
                                list = val.Values<string>().ToList();
                            }

                            errors.Add(name, list);
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                errors.Add(e.Message, new List<string>() { json });
            }

            // KVPs are structs and can never be null. Instead, check if the first error equals the default kvp value.
            if (errors.FirstOrDefault().Equals(default(KeyValuePair<string, IEnumerable<string>>)))
            {
                return null;
            }

            return errors;
        }
    }
}
