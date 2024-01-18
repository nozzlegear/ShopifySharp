using System.Net;

namespace ShopifySharp.Infrastructure;

/// <summary>
/// A type that analyzes HTTP responses and exceptions and determines if they should be retried,
/// and/or analyzes responses and determines if they should be treated as error responses.
/// </summary>
/// <param name="retryUnexpectedRateLimitResponse">
/// Whether the classifier should consider a response retriable when it was unexpectedly rate limited. This can happen,
/// for example, if one tries to create too many Shopify products too quickly on a development store. Shopify will
/// return a 429 Too Many Requests status code, despite the leaky bucket not reaching the API rate limit.
/// </param>
/// <param name="maximumNonRateLimitRetriesPerRequest">
/// The maximum number of times the classifier should classify <see cref="IsRetriableStatusCode"/> responses as retriable.
/// </param>
/// <remarks>
/// Source: Azure.Core SDK
/// https://github.com/Azure/azure-sdk-for-net/blob/68a0baaf8fecfb6dc6847acc3140f1a206d327db/sdk/core/Azure.Core/src/ResponseClassifier.cs
/// </remarks>
internal class ResponseClassifier(bool retryUnexpectedRateLimitResponse, int maximumNonRateLimitRetriesPerRequest = 3)
{
    // TODO: once the API design is finalized, make this class public and available to everyone using ShopifySharp

    /// <summary>
    /// Specifies if the request should be retried based on the response status code.
    /// </summary>
    public virtual bool IsRetriableStatusCode(HttpStatusCode statusCode)
    {
        switch ((int)statusCode)
        {
            case 408: // Request Timeout
            case 429: // Too Many Requests
            case 500: // Internal Server Error
            case 502: // Bad Gateway
            case 503: // Service Unavailable
            case 504: // Gateway Timeout
                return true;
            default:
                return false;
        }
    }

    /// <summary>
    /// Specifies if the request was not successful based on the exception thrown.
    /// </summary>
    /// <param name="ex">The exception being checked.</param>
    /// <param name="totalRetriesAttempted">The total number of retries that have been attempted for the request that caused this exception.</param>
    public virtual bool IsRetriableException(ShopifyException ex, int totalRetriesAttempted)
    {
        if (ex is ShopifyRateLimitException { Reason: ShopifyRateLimitReason.BucketFull })
        {
            return true;
        }

        if (ex is ShopifyRateLimitException { Reason: ShopifyRateLimitReason.Other })
        {
            // Only retry this type of 429 rate limit exceptions if the classifier is configured to do so
            return retryUnexpectedRateLimitResponse;
        }

        if (ex is ShopifyHttpException { HttpStatusCode: var statusCode } && IsRetriableStatusCode(statusCode) && totalRetriesAttempted <= maximumNonRateLimitRetriesPerRequest)
        {
            return true;
        }

        return false;
    }
}
