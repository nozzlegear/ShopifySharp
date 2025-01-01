#if NETSTANDARD2_0
using System.Text;
#else
using System.Buffers;
using System.Net.Http.Headers;
#endif
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace ShopifySharp.Infrastructure.Serialization.Http;

public class GraphHttpContentSerializer(JsonSerializerOptions jsonSerializerOptions) : IHttpContentSerializer
{
    public HttpContent SerializeGraphRequest(RequestUri requestUri, GraphRequest graphRequest)
    {
        var jsonData = new Dictionary<string, object>
        {
            { "query", graphRequest.Query },
            { "variables", graphRequest.Variables },
        };

#if NET6_0_OR_GREATER
        var bufferWriter = new ArrayBufferWriter<byte>();
        using var utf8JsonWriter = new Utf8JsonWriter(bufferWriter);

        JsonSerializer.Serialize(utf8JsonWriter, jsonData, jsonSerializerOptions);

        var content = new ReadOnlyMemoryContent(bufferWriter.WrittenMemory);
        content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
#else
        var jsonStr = JsonSerializer.Serialize(jsonData, jsonSerializerOptions);
        const string mediaType = "application/json";
        var content = new StringContent(jsonStr, Encoding.UTF8, mediaType);
#endif
        return content;
    }
}
