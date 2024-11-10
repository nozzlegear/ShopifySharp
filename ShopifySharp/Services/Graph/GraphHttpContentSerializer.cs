using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Services.Graph;

public class GraphHttpContentSerializer(JsonSerializerOptions jsonSerializerOptions) : IHttpContentSerializer
{
    public HttpContent SerializeGraphRequest(RequestUri requestUri, GraphRequest graphRequest)
    {
        var json = JsonSerializer.Serialize(new Dictionary<string, object>
        {
            {"query", graphRequest.Query},
            {"variables", graphRequest.Variables},
        }, jsonSerializerOptions);
        return new StringContent(json, Encoding.UTF8, "application/json");
    }
}
