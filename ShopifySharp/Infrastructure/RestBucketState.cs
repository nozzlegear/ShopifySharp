using System.Linq;
using System.Net.Http;

namespace ShopifySharp
{
    public class RestBucketState
    {
        public int CurrentlyUsed { get; init; }

        public int MaxAvailable { get; init; }

        public const string RESPONSE_HEADER_API_CALL_LIMIT = "X-Shopify-Shop-Api-Call-Limit";

        public static RestBucketState Get(HttpResponseMessage response)
        {
            string headerValue = response.Headers.FirstOrDefault(kvp => kvp.Key == RESPONSE_HEADER_API_CALL_LIMIT)
                                       .Value
                                       ?.FirstOrDefault();

            if (headerValue == null)
                return null;


            var split = headerValue.Split('/');
            if (split.Length == 2 && int.TryParse(split[0], out int currentlyUsed) &&
                                     int.TryParse(split[1], out int maxAvailable))
            {
                return new RestBucketState
                {
                    CurrentlyUsed = currentlyUsed,
                    MaxAvailable = maxAvailable
                };
            }

            return null;
        }
    }
}
