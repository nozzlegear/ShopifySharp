#nullable enable
using System.Collections.Generic;
using System.Net;

namespace ShopifySharp.Infrastructure;

public class ShopifyHttpException(
    HttpStatusCode statusCode,
    ICollection<string> errors,
    string message,
    string rawResponseBody,
    string? requestId)
    : ShopifyException(statusCode, errors, message, rawResponseBody, requestId)
{
    /// The Http response status code.
    public new readonly HttpStatusCode HttpStatusCode = statusCode;

    /// A list of error messages returned by Shopify.
    public new readonly ICollection<string> Errors = errors;

    /// The raw response body returned by Shopify.
    public new readonly string RawBody = rawResponseBody;

    /// The X-Request-Id header returned by Shopify. This can be used when working with the Shopify support team to identify the failed request.
    public new readonly string? RequestId = requestId;

    /// Extra details about the request, for logging purposes.
    public readonly string? RequestInfo;

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
}
