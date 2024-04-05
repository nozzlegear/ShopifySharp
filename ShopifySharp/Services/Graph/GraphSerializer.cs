#nullable enable

using System.Collections.Generic;

namespace ShopifySharp;

public interface IGraphSerializer
{
    string SerializeToJson(IDictionary<string, object> graphRequest);
    T? DeserializeFromJson<T>(string json) where T : class;
}

public class GraphSerializer : IGraphSerializer
{
    public T? DeserializeFromJson<T>(string json) where T : class
    {
#if NET6_0_OR_GREATER
        return GraphQL.Serializer.Deserialize<T>(json);
#else
        return Infrastructure.Serializer.Deserialize<T>(json);
#endif
    }

    public string SerializeToJson(IDictionary<string, object> graphRequest)
    {
#if NET6_0_OR_GREATER
        return GraphQL.Serializer.Serialize(graphRequest);
#else
        return Infrastructure.Serializer.Serialize(graphRequest);
#endif
    }
}
