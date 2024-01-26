using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopifySharp.Infrastructure
{
    public class CloneableRequestMessage: HttpRequestMessage
    {
        public CloneableRequestMessage(Uri url, HttpMethod method, HttpContent content = null) : base(method, url)
        {
            if (content != null)
            {
                Content = content;
            }
        }

        [Obsolete("This method has been replaced with " + nameof(CloneAsync) + ", it will be removed in a future version of ShopifySharp.")]
        public CloneableRequestMessage Clone()
        {
            var newContent = Content;

            if (newContent is JsonContent c)
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

        public async Task<CloneableRequestMessage> CloneAsync()
        {
            HttpContent newContent = Content switch
            {
                JsonContent c => c.Clone(),
                // TODO: use new ReadOnlyMemoryContent(bytes) when cloning. Can import System.Memory from Nuget for netstandard2.0 targets
                StringContent s => new StreamContent(await s.ReadAsStreamAsync()),
                StreamContent s => new StreamContent(await s.ReadAsStreamAsync()),
                ByteArrayContent b => new ByteArrayContent(await b.ReadAsByteArrayAsync()),
                null => null,
                _ => throw new ArgumentOutOfRangeException(nameof(Content), Content.GetType().FullName, "Unhandled HttpContent type, ")
            };

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
