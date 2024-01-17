#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    public class ShopifyException : Exception
    {
        /// The Http response status code.
        [Obsolete("This property has been moved to the " + nameof(ShopifyHttpException) + " and will be removed in a future version of ShopifySharp.")]
        public HttpStatusCode HttpStatusCode { get; }

        /// The XRequestId header returned by Shopify. Can be used when working with the Shopify support team to identify the failed request.
        [Obsolete("This property has been moved to the " + nameof(ShopifyHttpException) + " and will be removed in a future version of ShopifySharp.")]
        public string RequestId { get; }

        /// A list of error messages returned by Shopify.
        [Obsolete("This property has been moved to the " + nameof(ShopifyHttpException) + " and will be removed in a future version of ShopifySharp.")]
        public IEnumerable<string> Errors { get; } = Enumerable.Empty<string>();

        /// The raw string body returned by Shopify.
        [Obsolete("This property has been moved to the " + nameof(ShopifyHttpException) + " and will be removed in a future version of ShopifySharp.")]
        public string RawBody { get; }

        public ShopifyException() { }

        public ShopifyException(string message, Exception? innerException = null) : base(message, innerException) { }

        public ShopifyException(
            HttpStatusCode httpStatusCode,
            IEnumerable<string> errors,
            string message,
            string rawBody,
            string requestId) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            Errors = (errors ?? Enumerable.Empty<string>()).ToArray();
            RawBody = rawBody;
            RequestId = requestId;
        }
    }
}
