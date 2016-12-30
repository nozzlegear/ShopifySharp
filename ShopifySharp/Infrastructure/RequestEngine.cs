using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using ShopifySharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public static class RequestEngine
    {
        private static IRequestExecutionPolicy _executionPolicy = new DefaultRequestExecutionPolicy();

        public static void SetExecutionPolicy(IRequestExecutionPolicy executionPolicy)
        {
            _executionPolicy = executionPolicy;
        }

        /// <summary>
        /// Attempts to build a shop API <see cref="Uri"/> for the given shop.
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
                if (Uri.IsWellFormedUriString(Uri.UriSchemeHttps + Uri.SchemeDelimiter + myShopifyUrl, UriKind.Absolute) == false)
                {
                    throw new ShopifyException($"The given {nameof(myShopifyUrl)} cannot be converted into a well-formed URI.");
                }
                else
                {
                    myShopifyUrl = Uri.UriSchemeHttps + Uri.SchemeDelimiter + myShopifyUrl;
                }
            }

            UriBuilder builder = new UriBuilder(myShopifyUrl)
            {
                Path = "admin/",
                Scheme = Uri.UriSchemeHttps,
                Port = 443 //SSL port
            };

            return builder.Uri;
        }

        /// <summary>
        /// Creates a new <see cref="RestClient"/> configured for use with ShopifySharp.
        /// </summary>
        /// <param name="shopUri">The base shop <see cref="Uri"/>.</param>
        /// <param name="shopAccessToken">An optional shop access token. If present, the token will be set as a default X-Shopify-Access-Token for every request.</param>
        /// <returns>The configured <see cref="RestClient"/>.</returns>
        public static RestClient CreateClient(Uri shopUri, string shopAccessToken = null)
        {
            RestClient client = new RestClient(shopUri);

            //Set up the JSON.NET deserializer for the RestSharp client
            JsonNetSerializer deserializer = new JsonNetSerializer();
            client.AddHandler("application/json", deserializer);
            client.AddHandler("text/json", deserializer);

            if (string.IsNullOrEmpty(shopAccessToken) == false)
            {
                //Configure default access token header
                client.AddDefaultHeader("X-Shopify-Access-Token", shopAccessToken);
            }

            return client;
        }

        /// <summary>
        /// Creates an <see cref="IRestRequest"/> by setting the method and the necessary Json.Net serializer.
        /// </summary>
        /// <param name="path">The request's path.</param>
        /// <param name="method">The HTTP <see cref="Method"/> to use for the request.</param>
        /// <param name="rootElement">The root element to deserialize. Default is null.</param>
        /// <returns>The prepared <see cref="IRestRequest"/>.</returns>
        /// <remarks>We've created this method to ensure every request uses our custom <see cref="JsonNetSerializer"/>, which ensures 
        /// that each class serializes with the proper <see cref="JsonPropertyAttribute"/></remarks>
        public static IRestRequest CreateRequest(string path, Method method, string rootElement = null)
        {
            return new RestRequest(path, method)
            {
                JsonSerializer = new JsonNetSerializer(),
                RootElement = rootElement
            };
        }

        /// <summary>
        /// Executes a <see cref="IRestRequest"/> and returns a JToken for querying, or throws an exception when the response is invalid. 
        /// Use this method when the expected response is a single line or simple object that doesn't warrant creating its own class.
        /// </summary>
        /// <param name="client">A <see cref="RestClient"/>.</param>
        /// <param name="request">An <see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="JToken"/> to be queried.</returns>
        public static async Task<JToken> ExecuteRequestAsync(RestClient client, IRestRequest request)
        {
            return await _executionPolicy.Run(client, request, async() =>
            {
                //Make request
                IRestResponse response = await client.ExecuteTaskAsync(request);

                //Check for and throw exception when necessary.
                CheckResponseExceptions(response);

                //Get the raw response string
                string respString = Encoding.UTF8.GetString(response.RawBytes);

                //Parse the string if it exists, else parse an empty object. The empty object is expected when
                //Shopify returns a 0-byte body in it's response (e.g. when deleting a charge). 
                var result = JToken.Parse(string.IsNullOrEmpty(respString) ? "{}" : respString);
                return new RequestResult<JToken>(response, result);
            });
        }

        /// <summary>
        /// Executes a <see cref="IRestRequest"/> and returns data of the given type, or throws an exception when the response is invalid.
        /// </summary>
        /// <typeparam name="T">The type of data to be returned.</typeparam>
        /// <param name="client">A <see cref="RestClient"/>.</param>
        /// <param name="request">An <see cref="IRestRequest"/>.</param>
        /// <returns>The data.</returns>
        public static async Task<T> ExecuteRequestAsync<T>(RestClient client, IRestRequest request) where T : new()
        {
            return await _executionPolicy.Run(client, request, async () =>
            {
                //Make request
                IRestResponse<T> response = await client.ExecuteTaskAsync<T>(request);

                //Check for and throw exception when necessary.
                CheckResponseExceptions(response);

                var result = response.Data;
                return new RequestResult<T>(response, result);
            });
        }

        /// <summary>
        /// Checks an <see cref="IRestResponse" /> for exceptions or invalid responses. Throws an exception when necessary.
        /// </summary>
        /// <param name="response">The response.</param>
        public static void CheckResponseExceptions(IRestResponse response)
        {
            if (response.StatusCode != HttpStatusCode.OK && response.StatusCode != HttpStatusCode.Created)
            {
                var json = Encoding.UTF8.GetString(response.RawBytes ?? new byte[] { });
                Dictionary<string, IEnumerable<string>> errors = ParseErrorJson(json);

                var code = response.StatusCode;
                var message = $"Response did not indicate success. Status: {(int)code} {response.StatusDescription}.";

                if (errors == null)
                {
                    errors = new Dictionary<string, IEnumerable<string>>()
                    {
                        {
                            $"{(int)code} {response.StatusDescription}",
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
                    throw new ShopifyRateLimitException(code, errors, message, json);
                }
                
                throw new ShopifyException(code, errors, message, json);
            }

            if (response.ErrorException != null)
            {
                //Checking this second, because Shopify errors sometimes return incomplete objects along with errors, 
                //which cause Json deserialization to throw an exception. Parsing the Shopify error is more important 
                //than throwing this deserialization exception.
                throw response.ErrorException;
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
