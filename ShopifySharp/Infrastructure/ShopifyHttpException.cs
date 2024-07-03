#nullable enable
using System.Collections.Generic;
using System.Net;

namespace ShopifySharp;

public class ShopifyHttpException(
    HttpStatusCode statusCode,
    ICollection<string> errors,
    string message,
    string rawResponseBody,
    string? requestId)
    : ShopifyException(message)
{
    public ShopifyHttpException(
        string requestInfo,
        HttpStatusCode statusCode,
        ICollection<string> errors,
        string message,
        string rawResponseBody,
        string? requestId)
        : this(statusCode, errors, message, rawResponseBody, requestId)
    {
        RequestInfo = requestInfo;
    }

    /// The Http response status code.
    public readonly HttpStatusCode HttpStatusCode = statusCode;

    /// A list of error messages returned by Shopify.
    public readonly ICollection<string> Errors = errors;

    /// The raw response body returned by Shopify.
    public readonly string RawBody = rawResponseBody;

    /// The X-Request-Id header returned by Shopify. This can be used when working with the Shopify support team to identify the failed request.
    public readonly string? RequestId = requestId;

    /// Extra details about the request, for logging purposes.
    public readonly string? RequestInfo;
}
