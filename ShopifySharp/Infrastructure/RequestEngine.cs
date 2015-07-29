using Humanizer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    internal static class RequestEngine
    {
        /// <summary>
        /// Executes a <see cref="IRestRequest"/> and returns a JToken for querying, or throws an exception when the response is invalid. Use this method when the expected response is a single line or simple object that doesn't warrant creating its own class.
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
        private static void CheckResponseExceptions(IRestResponse response)
        {
            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }
            else if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpStatusCode code = response.StatusCode;
                ShopifyError error = JsonConvert.DeserializeObject<ShopifyError>(Encoding.UTF8.GetString(response.RawBytes));
                string message = string.IsNullOrEmpty(error.Errors) ?
                    "Response did not indicate success. Status: {0} {1}.".FormatWith((int)code, response.StatusDescription) :
                    error.Errors;

                throw new ShopifyException(code, error, message);
            }
        }
    }
}
