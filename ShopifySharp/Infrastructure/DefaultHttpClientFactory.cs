using System;
using System.Net.Http;

namespace ShopifySharp.Infrastructure
{
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
