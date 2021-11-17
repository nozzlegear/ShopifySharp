using System.Net.Http;
using Microsoft.Extensions.Http;

namespace ShopifySharp.Infrastructure
{
    /// <summary>
    /// ShopifySharp's default <see cref="IHttpClientFactory" />, which uses a static <see cref="HttpClient" />.
    /// </summary>
    public class DefaultHttpClientFactory : IHttpClientFactory
    {
        private static readonly HttpClient _Client = new HttpClient();

        public HttpClient CreateClient(string name)
        {
            return _Client;
        }
    }
}
