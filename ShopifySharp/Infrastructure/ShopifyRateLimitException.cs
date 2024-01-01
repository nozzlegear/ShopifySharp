using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace ShopifySharp
{
    /// <summary>
    /// An exception thrown when an API call has reached Shopify's rate limit.
    /// </summary>
    public class ShopifyRateLimitException : ShopifyException
    {
        public int? RetryAfterSeconds { get; private set; }

        //When a 429 is returned because the bucket is full, Shopify doesn't include the X-Shopify-Shop-Api-Call-Limit header in the response
        public ShopifyRateLimitReason Reason => HttpResponse.Headers.Contains(RestBucketState.RESPONSE_HEADER_API_CALL_LIMIT) ? ShopifyRateLimitReason.Other : ShopifyRateLimitReason.BucketFull;

        public ShopifyRateLimitException(HttpResponseMessage response, 
                                         HttpStatusCode httpStatusCode,
                                         IEnumerable<string> errors,
                                         string message,
                                         string jsonError,
                                         string requestId) 
            : base(response, httpStatusCode, errors, message, jsonError, requestId)
        {
            ExtractRetryAfterSeconds(response);
        }

        private void ExtractRetryAfterSeconds(HttpResponseMessage response)
        {
            string strRetryAfer = response.Headers
                                        .FirstOrDefault(kvp => kvp.Key == "Retry-After")
                                        .Value
                                        ?.FirstOrDefault();

            if (int.TryParse(strRetryAfer, out var retryAfterSeconds))
            {
                RetryAfterSeconds = retryAfterSeconds;
            }
        }
    }
}
