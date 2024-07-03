using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
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

    public virtual async Task<CloneableRequestMessage> CloneAsync(CancellationToken cancellationToken = default)
    {
        var newContent = Content is null ? null : await CloneToStreamOrReadOnlyMemoryContent(Content, cancellationToken);
        var cloned = new CloneableRequestMessage(RequestUri, Method, newContent);

        // Copy over the request's headers which includes the access token if set
        foreach (var header in Headers)
        {
            cloned.Headers.Add(header.Key, header.Value);
        }

        return cloned;
    }

    private static async Task<HttpContent> CloneToStreamOrReadOnlyMemoryContent(HttpContent originalStreamContent, CancellationToken cancellationToken = default)
    {
        HttpContent clonedContent;

#if NET6_0_OR_GREATER
        var rs = new ReadOnlyMemory<byte>(await originalStreamContent.ReadAsByteArrayAsync(cancellationToken));
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
