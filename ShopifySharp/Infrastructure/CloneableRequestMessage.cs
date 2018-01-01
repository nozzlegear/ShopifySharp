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

            return new CloneableRequestMessage(RequestUri, Method, newContent);
        }
    }
}