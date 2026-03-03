using System.Net.Http;
using JetBrains.Annotations;

namespace ShopifySharp.Tests.TestClasses;

[UsedImplicitly]
public class FakeHttpClient(HttpMessageHandler handler) : HttpClient(handler), IDisposable
{
    public new virtual void Dispose()
    {
        base.Dispose();
    }
}
