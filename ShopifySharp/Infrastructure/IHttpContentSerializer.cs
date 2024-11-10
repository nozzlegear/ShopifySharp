using System.Net.Http;

namespace ShopifySharp.Infrastructure;

public interface IHttpContentSerializer
{
    // public bool CanSerializeRequest(RequestType requestType, RequestUri requestUri);
    // public HttpContent SerializeRequest(RequestType requestType, RequestUri requestUri, IReadOnlyDictionary<string, object> requestData);
    public HttpContent SerializeGraphRequest(RequestUri requestUri, GraphRequest graphRequest);
    // public HttpContent SerializeRestRequest(RequestUri requestUri, RestRequest restRequest);
    // public HttpContent SerializePartnerRequest(RequestUri requestUri, PartnerRequest partnerRequest);
}