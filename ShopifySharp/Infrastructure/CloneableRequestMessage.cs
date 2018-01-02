using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopifySharp.Infrastructure
{
    public class CloneableRequestMessage : HttpRequestMessage
    {
        public CloneableRequestMessage(Uri url, HttpMethod method, HttpContent content = null) : base(method, url)
        {
            if (content != null)
            {
                this.Content = content;
            }
        }

        public CloneableRequestMessage Clone()
        {
            HttpContent newContent = Content;

            if (newContent != null && newContent is JsonContent c)
            {
                newContent = c.Clone();
            }

            var cloned = new CloneableRequestMessage(RequestUri, Method, newContent);

            // Copy over the request's headers which includes the access token if set
            foreach (var header in Headers)
            {
                cloned.Headers.Add(header.Key, header.Value);
            }

            return cloned;
        }
    }
}