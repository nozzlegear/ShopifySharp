#nullable enable
using System;
using System.IO;
using System.Text.Json;

namespace ShopifySharp.Infrastructure.Serialization.Json;

internal class SystemJsonNode(JsonElement element, JsonDocument? document = null) : IJsonNode
{
    private bool Disposed { get; set; }

    public SystemJsonNode(JsonDocument jsonDocument) : this(jsonDocument.RootElement, jsonDocument)
    {
    }

    public JsonElement GetRawObject() => element;

    object IJsonNode.GetRawObject() => GetRawObject();

    public JsonNodeValueKind ValueKind { get; } = element.ValueKind switch
    {
        JsonValueKind.Undefined => JsonNodeValueKind.Undefined,
        JsonValueKind.Object => JsonNodeValueKind.Object,
        JsonValueKind.Array => JsonNodeValueKind.Array,
        JsonValueKind.String => JsonNodeValueKind.String,
        JsonValueKind.Number => JsonNodeValueKind.Number,
        JsonValueKind.True => JsonNodeValueKind.True,
        JsonValueKind.False => JsonNodeValueKind.False,
        JsonValueKind.Null => JsonNodeValueKind.Null,
        _ => throw new ArgumentOutOfRangeException(nameof(element.ValueKind), element.ValueKind, $"Unknown ValueKind '{element.ValueKind}'.")
    };

    public bool TryGetProperty(string propertyName, out IJsonNode node)
    {
        var found = element.TryGetProperty(propertyName, out var property);
        node = found ? new SystemJsonNode(property, document) : null!;
        return found;
    }

    public IJsonNode GetProperty(string propertyName) =>
        new SystemJsonNode(element.GetProperty(propertyName), document);

    public IJsonNodeObjectEnumerator EnumerateObject() =>
        new SystemJsonNodeObjectEnumerator(element.EnumerateObject());

    public IJsonNodeArrayEnumerator EnumerateArray() =>
        new SystemJsonNodeArrayEnumerator(element.EnumerateArray());

    public string GetRawText() =>
        element.GetRawText();

    public int GetArrayLength() => element.GetArrayLength();

    public int GetPropertyCount() => element.GetPropertyCount();

    public void Dispose()
    {
        if (Disposed)
            return;
        Disposed = true;
        document?.Dispose();
    }
}
