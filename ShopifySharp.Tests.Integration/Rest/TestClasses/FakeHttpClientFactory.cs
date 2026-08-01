using System.Net.Http;

namespace ShopifySharp.Tests.Integration.Rest.TestClasses;

public class FakeHttpClientFactory(FakeHttpClient fakeClient) : IHttpClientFactory
{
    public HttpClient CreateClient(string name)
    {
        return fakeClient;
    }
}