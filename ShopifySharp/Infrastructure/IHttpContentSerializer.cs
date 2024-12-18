using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp.Infrastructure;

public interface IHttpContentSerializer
{
    public HttpContent SerializeGraphRequest(RequestUri requestUri, GraphRequest graphRequest);
}
