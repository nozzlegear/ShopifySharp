using System.Linq;
using System.Net.Http.Headers;

namespace ShopifySharp
{
    public class RestBucketState
    {
        public int CurrentlyUsed { get; private set; }

        public int MaxAvailable { get; private set; }

        public const string RESPONSE_HEADER_API_CALL_LIMIT = "X-Shopify-Shop-Api-Call-Limit";

        public static RestBucketState Get(HttpResponseHeaders responseHeaders)
        {
            string headerValue = responseHeaders.FirstOrDefault(kvp => kvp.Key == RESPONSE_HEADER_API_CALL_LIMIT)
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
