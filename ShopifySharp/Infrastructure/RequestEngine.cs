using Humanizer;
using Newtonsoft.Json;
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
        public static async Task<T> ExecuteRequestAsync<T>(RestClient client, RestRequest request)
        {
            //Make request
            IRestResponse<T> response = await client.ExecuteTaskAsync<T>(request);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }
            else if (response.StatusCode != HttpStatusCode.OK)
            {
                HttpStatusCode code = response.StatusCode;
                ShopifyError error = JsonConvert.DeserializeObject<ShopifyError>(Encoding.UTF8.GetString(response.RawBytes));
                string message = "Response status did not indicate success. Status: {0} - {1}.".FormatWith(response.StatusCode, response.StatusDescription);

                throw new ShopifyException(code, error, message);
            }

            return response.Data;
        }
    }
}
