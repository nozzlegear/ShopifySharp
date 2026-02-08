#nullable enable
using System;
using System.Linq;
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

    public bool TryGetPropertyCaseInsensitive(string propertyName, out IJsonElement result)
    {
        if (ValueType != JsonValueType.Object)
            throw new InvalidOperationException($"Expected {nameof(ValueType)} to be {nameof(JsonValueType.Object)}, but it was {ValueType}.");

        // Check if there's an exact match first (fast path)
        if (TryGetProperty(propertyName, out result))
            return true;

        // Next, try a case-insensitive search on the object's properties
        foreach (var property in element.EnumerateObject().Where(property => property.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase)))
        {
            result = new SystemJsonElement(property.Value, document);
            return true;
        }

        // Property doesn't exist
        result = null!;
        return false;
    }

    public IJsonObjectEnumerator EnumerateObject() =>
        new SystemJsonObjectEnumerator(element.EnumerateObject());

    public string GetRawText() =>
        element.GetRawText();

    public int GetArrayLength() => element.GetArrayLength();

    public int GetPropertyCount() => element.GetPropertyCount();

    public bool ValueEquals(string? text) => element.ValueEquals(text);

    public bool ValueEquals(ReadOnlySpan<byte> utf8Text) => element.ValueEquals(utf8Text);

    public bool ValueEquals(ReadOnlySpan<char> text) => element.ValueEquals(text);

    public bool ValueIsNullOrWhiteSpaceString()
    {
        if (ValueType == JsonValueType.Null)
            return true;
        if (ValueType != JsonValueType.String)
            return false;
        return ValueEquals(ReadOnlySpan<byte>.Empty) || string.IsNullOrWhiteSpace(element.GetString());
    }

    public void Dispose()
    {
        if (Disposed)
            return;
        Disposed = true;
        document?.Dispose();
    }
}
