using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace ShopifySharp
{
    public class ShopifyException : Exception
    {
        [Obsolete("This property is deprecated and will be removed in a future version of ShopifySharp.")]
        public HttpResponseMessage HttpResponse { get; }

        /// The Http response status code.
        public HttpStatusCode HttpStatusCode { get; }

        /// The XRequestId header returned by Shopify. Can be used when working with the Shopify support team to identify the failed request.
        public string RequestId { get; }

        /// A list of error messages returned by Shopify.
        public IEnumerable<string> Errors { get; } = Enumerable.Empty<string>();

        /// The raw string body returned by Shopify.
        public string RawBody { get; }

        public ShopifyException() { }

        public ShopifyException(string message) : base(message) { }

        public ShopifyException(HttpResponseMessage response, HttpStatusCode httpStatusCode, IEnumerable<string> errors, string message, string rawBody, string requestId) : base(message)
        {
            HttpResponse = response;
            HttpStatusCode = httpStatusCode;
            Errors = (errors ?? Enumerable.Empty<string>()).ToArray();
            RawBody = rawBody;
            RequestId = requestId;
        }
    }
}
