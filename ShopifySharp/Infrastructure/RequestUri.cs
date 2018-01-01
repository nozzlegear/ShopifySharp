using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

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
                var value = JsonConvert.SerializeObject(kvp.Value);

                return $"{kvp.Key}={Uri.EscapeDataString(value)}";
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