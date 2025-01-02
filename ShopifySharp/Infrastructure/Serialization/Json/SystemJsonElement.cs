#nullable enable
using System.Text.Json;

namespace ShopifySharp.Infrastructure.Serialization.Json;

internal class SystemJsonElement(JsonElement element, JsonDocument? document = null) : IJsonElement
{
    private bool Disposed { get; set; }

    public SystemJsonElement(JsonDocument jsonDocument) : this(jsonDocument.RootElement, jsonDocument)
    {
    }

    public JsonElement GetRawObject() => element;

    object IJsonElement.GetRawObject() => GetRawObject();

    public JsonValueType ValueType { get; } = element.ValueKind switch
    {
        JsonValueKind.Object => JsonValueType.Object,
        JsonValueKind.Array => JsonValueType.Array,
        JsonValueKind.String => JsonValueType.String,
        JsonValueKind.Number => JsonValueType.Number,
        JsonValueKind.True => JsonValueType.True,
        JsonValueKind.False => JsonValueType.False,
        JsonValueKind.Null => JsonValueType.Null,
        _ => JsonValueType.Undefined
    };

    public bool TryGetProperty(string propertyName, out IJsonElement result)
    {
        var found = element.TryGetProperty(propertyName, out var property);
        result = found ? new SystemJsonElement(property, document) : null!;
        return found;
    }

    public IJsonElement GetProperty(string propertyName) =>
        new SystemJsonElement(element.GetProperty(propertyName), document);

    public IJsonObjectEnumerator EnumerateObject() =>
        new SystemJsonObjectEnumerator(element.EnumerateObject());

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
