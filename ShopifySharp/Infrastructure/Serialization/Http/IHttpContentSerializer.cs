using System.Net.Http;

namespace ShopifySharp.Infrastructure.Serialization.Http;

public interface IHttpContentSerializer
{
    public HttpContent SerializeGraphRequest(RequestUri requestUri, GraphRequest graphRequest);
}
