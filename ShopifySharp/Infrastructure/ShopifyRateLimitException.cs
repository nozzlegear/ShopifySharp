using System.Collections.Generic;
using System.Net;
using ShopifySharp.Infrastructure;

namespace ShopifySharp;

/// An exception thrown when an API call has reached Shopify's rate limit.
public class ShopifyRateLimitException(
    ShopifyRateLimitReason reason,
    int? retryAfterSeconds,
    HttpStatusCode statusCode,
    string requestId,
    ICollection<string> errors,
    string rawResponseBody)
    : ShopifyHttpException(statusCode, requestId, errors, rawResponseBody)
{
    public readonly int? RetryAfterSeconds = retryAfterSeconds;

    //When a 429 is returned because the bucket is full, Shopify doesn't include the X-Shopify-Shop-Api-Call-Limit header in the response
    public readonly ShopifyRateLimitReason Reason = reason;
}
