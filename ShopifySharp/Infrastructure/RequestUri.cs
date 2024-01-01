using System;
using System.Linq;
using System.Collections.Generic;

namespace ShopifySharp.Infrastructure
{
    public class RequestUri
    {
        public RequestUri(Uri uri)
        {
            Url = uri;
        }

        private Uri Url;

        public Dictionary<string, object> QueryParams { get; } = new Dictionary<string, object>();

        public Uri ToUri()
        {
            // Combine the url and the query param dictionary into a uri
            var query = QueryParams.Select(kvp =>
            {
                return $"{kvp.Key}={Uri.EscapeDataString(kvp.Value.ToString())}";
            });
            var ub = new UriBuilder(Url)
            {
                Query = string.Join("&", query)
            };

            return ub.Uri;
        }

        public override string ToString() => ToUri().ToString();
    }
}