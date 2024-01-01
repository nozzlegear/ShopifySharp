#nullable enable
// ReSharper disable InconsistentNaming

namespace ShopifySharp
{
    public interface IShopifyService
    {
        string APIVersion { get; }
        bool SupportsAPIVersioning { get; }

        void SetExecutionPolicy(IRequestExecutionPolicy policy);

        // TODO: determine best method for DI and testing? letting devs set HttpClient, or HttpClientFactory?
        //void SetHttpClient(HttpClient client);
        //void SetHttpClientFactory(IHttpClientFactory factory);
    }
}
