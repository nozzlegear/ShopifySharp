using System;
using System.Net.Http;

namespace ShopifySharp.Infrastructure
{
    /// <summary>
    /// ShopifySharp's default <see cref="IHttpClientFactory" />, which uses a static <see cref="HttpClient" />.
    /// </summary>
    // TODO: remove this class in a future release (6.4+)
    [Obsolete("This class will be removed in a future version of ShopifySharp. It ignores all configurations and therefore has the potential to introduce subtle bugs when used outside of ShopifySharp.")]
    public class DefaultHttpClientFactory : IHttpClientFactory
    {
        private static readonly HttpClient _Client = new HttpClient();

        public HttpClient CreateClient(string name)
        {
            return _Client;
        }
    }

    /// <summary>
    /// ShopifySharp's internal <see cref="IHttpClientFactory" />, which uses a static <see cref="HttpClient" />.
    /// </summary>
    internal class InternalHttpClientFactory : IHttpClientFactory
    {
        private static readonly HttpClient Client = new HttpClient();

        public HttpClient CreateClient(string name)
        {
            return Client;
        }
    }
}