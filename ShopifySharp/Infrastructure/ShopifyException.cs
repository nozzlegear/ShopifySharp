using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ShopifySharp
{
    public class ShopifyException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        /// <summary>
        /// The XRequestId header returned by Shopify. Can be used when working with the Shopify support team to identify the failed request.
        /// </summary>
        public string RequestId { get; set; }

        /// <remarks>
        /// List is always initialized to ensure null reference errors won't be thrown when trying to check error messages.
        /// </remarks>
        public IEnumerable<string> Errors { get; set; } = Enumerable.Empty<string>();

        /// <summary>
        /// The raw JSON string returned by Shopify.
        /// </summary>
        public string RawBody { get; set; }

        public ShopifyException() { }

        public ShopifyException(string message) : base(message) { }

        public ShopifyException(HttpStatusCode httpStatusCode, IEnumerable<string> errors, string message, string rawBody, string requestId) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            Errors = (errors ?? Enumerable.Empty<string>()).ToArray();
            RawBody = rawBody;
            RequestId = requestId;
        }
    }
}
