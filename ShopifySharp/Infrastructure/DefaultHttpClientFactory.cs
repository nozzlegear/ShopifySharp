using System;
using System.Net;
using System.Net.Http;

namespace ShopifySharp.Infrastructure;

/// <summary>
/// ShopifySharp's internal <see cref="IHttpClientFactory" />, which uses a static <see cref="HttpClient" /> with
/// automatic response decompression enabled.
/// </summary>
internal class InternalHttpClientFactory : IHttpClientFactory
{
    private static readonly HttpClient Client = new HttpClient(new HttpClientHandler
    {
#if NET
        AutomaticDecompression = DecompressionMethods.All
#else
        AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
#endif
    });

    public HttpClient CreateClient(string name)
    {
        return Client;
    }
}