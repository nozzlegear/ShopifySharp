#nullable enable
using System.Collections.Generic;
using System.Net;

namespace ShopifySharp.Infrastructure;

public class ShopifyHttpException(
    HttpStatusCode statusCode,
    string requestId,
    ICollection<string> errors,
    string rawResponseBody) : ShopifyException
{
    /// The Http response status code.
    public new readonly HttpStatusCode HttpStatusCode = statusCode;

    /// The X-Request-Id header returned by Shopify. This can be used when working with the Shopify support team to identify the failed request.
    public new readonly string RequestId = requestId;

    /// A list of error messages returned by Shopify.
    public new readonly ICollection<string> Errors = errors;

    /// The raw response body returned by Shopify.
    public new readonly string RawBody = rawResponseBody;
}
