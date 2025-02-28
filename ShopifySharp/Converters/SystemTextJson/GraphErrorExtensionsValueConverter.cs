#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ShopifySharp.Converters.SystemTextJson;

/// <summary>
/// Handles the conversion <c>{"Value":"foo"}</c> into <c>{"Value": {"$value":"foo"}}</c>
/// </summary>
public class GraphErrorExtensionsValueConverter : ObjectDictionaryConverter
{
    private const string ConstructedDictionaryKey = "$value";

    public override IReadOnlyDictionary<string, object?> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // We've seen GraphErrorExtensions.Value exhibit two structures so far:
        // 1. {"Value": {"foo": "bar", "baz": "bat"}}
        // 2. {"Value": "foo"}
        // If #2, map the value into a dictionary using the (arbitrary) key "$value"

        if (reader.TokenType == JsonTokenType.StartObject)
            return base.Read(ref reader, typeToConvert, options);

        object? value = reader.TokenType switch
        {
            JsonTokenType.String => reader.GetString(),
            JsonTokenType.Number => reader.GetInt64(),
            JsonTokenType.True or JsonTokenType.False => reader.GetBoolean(),
            JsonTokenType.Null => null,
            _ => throw new JsonException($"Unexpected token {reader.TokenType} when mapping a GraphErrorExtensionsValue object.")
        };

        return new Dictionary<string, object?>() { { ConstructedDictionaryKey, value } }.ToReadOnlyDictionary();
    }
}
