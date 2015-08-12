using Humanizer;
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
    static class RequestEngine
    {
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
                throw new ShopifyException("The given {0} cannot be converted into a well-formed URI.".FormatWith(nameof(myShopifyUrl)));
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
            //Make request
            IRestResponse response = await client.ExecuteTaskAsync(request);

            //Check for and throw exception when necessary.
            CheckResponseExceptions(response);

            return JToken.Parse(Encoding.UTF8.GetString(response.RawBytes));
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
            //Make request
            IRestResponse<T> response = await client.ExecuteTaskAsync<T>(request);
            
            //Check for and throw exception when necessary.
            CheckResponseExceptions(response);

            return response.Data;
        }

        /// <summary>
        /// Checks an <see cref="IRestResponse" /> for exceptions or invalid responses. Throws an exception when necessary.
        /// </summary>
        /// <param name="response">The response.</param>
        static void CheckResponseExceptions(IRestResponse response)
        {
            if (response.StatusCode != HttpStatusCode.OK && response.StatusCode != HttpStatusCode.Created)
            {
                string json = Encoding.UTF8.GetString(response.RawBytes);
                JToken parsed = JToken.Parse(json);
                ShopifyError error = new ShopifyError();

                if(parsed.Any(x => x.Path == "errors"))
                {
                    error.Errors = parsed["errors"].Type == JTokenType.String ? parsed.Value<string>("errors") : parsed["errors"].ToString(Formatting.Indented);
                }
                else
                {
                    error.Errors = "Unhandled error: " + json;
                }

                HttpStatusCode code = response.StatusCode;
                string message = string.IsNullOrEmpty(error.Errors) ?
                    "Response did not indicate success. Status: {0} {1}.".FormatWith((int)code, response.StatusDescription) :
                    error.Errors;

                throw new ShopifyException(code, error, message);
            }
            else if (response.ErrorException != null)
            {
                //Checking this second, because Shopify errors sometimes return incomplete objects along with errors, 
                //which cause Json deserialization to throw an exception. Parsing the Shopify error is more important 
                //than throwing this deserialization exception.
                throw response.ErrorException;
            }
        }
    }
}
