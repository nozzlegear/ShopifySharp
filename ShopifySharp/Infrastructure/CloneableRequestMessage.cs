using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopifySharp.Infrastructure;

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

            foreach (var header in Content.Headers)
            {
                if (!newContent.Headers.Contains(header.Key))
                {
                    newContent.Headers.Add(header.Key, header.Value);
                }
            }
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
        var newContent = Content is null ? null : await CloneToStreamOrReadOnlyMemoryContent(Content);
        var cloned = new CloneableRequestMessage(RequestUri, Method, newContent);

        // Copy over the request's headers which includes the access token if set
        foreach (var header in Headers)
        {
            cloned.Headers.Add(header.Key, header.Value);
        }

        return cloned;
    }

    private static async Task<HttpContent> CloneToStreamOrReadOnlyMemoryContent(HttpContent originalStreamContent)
    {
        HttpContent clonedContent;

#if NET6_0_OR_GREATER
        var rs = new ReadOnlyMemory<byte>(await originalStreamContent.ReadAsByteArrayAsync());
        clonedContent = new ReadOnlyMemoryContent(rs);
#else
            var ms = new System.IO.MemoryStream();
            await originalStreamContent.CopyToAsync(ms);
            ms.Position = 0;
            clonedContent = new StreamContent(ms);
#endif

        foreach (var header in originalStreamContent.Headers)
        {
            clonedContent.Headers.Add(header.Key, header.Value);
        }

        return clonedContent;
    }

    public async Task<string> GetRequestInfo()
    {
        var headers = this.Headers.Where(kv => kv.Value != null && kv.Key != ShopifyService.REQUEST_HEADER_ACCESS_TOKEN)
            .Select(kv => $"\t{kv.Key}: {string.Join(", ", kv.Value)}");
        var contents = this.Content switch
        {
            StringContent strContent => await strContent.ReadAsStringAsync(),
            null => "(none)",
            _ => this.Content.GetType().Name
        };

        return $"""
                Method: {this.Method}
                RequestUri: {this.RequestUri}
                Headers:
                [
                {string.Join(Environment.NewLine, headers)}
                ]
                Content: {contents}
                """;
    }
}