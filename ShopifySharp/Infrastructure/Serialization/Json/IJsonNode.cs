using System;

namespace ShopifySharp.Infrastructure.Serialization.Json;

public interface IJsonNode : IDisposable
{
    object GetRawObject();

    JsonNodeValueKind ValueKind { get; }

    bool TryGetProperty(string propertyName, out IJsonNode node);

    IJsonNode GetProperty(string propertyName);

    IJsonNodeObjectEnumerator EnumerateObject();

    string GetRawText();

    int GetArrayLength();

    int GetPropertyCount();
}
