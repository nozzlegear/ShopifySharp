#nullable enable
using System;

namespace ShopifySharp.Infrastructure.Serialization.Json;

public interface IJsonElement : IDisposable
{
    object GetRawObject();

    JsonValueType ValueType { get; }

    bool TryGetProperty(string propertyName, out IJsonElement result);

    IJsonElement GetProperty(string propertyName);

    IJsonObjectEnumerator EnumerateObject();

    string GetRawText();

    int GetArrayLength();

    int GetPropertyCount();

    bool ValueEquals(string? text);

    bool ValueEquals(ReadOnlySpan<byte> utf8Text);

    bool ValueEquals(ReadOnlySpan<char> text);

    bool ValueIsNullOrWhiteSpaceString();
}
