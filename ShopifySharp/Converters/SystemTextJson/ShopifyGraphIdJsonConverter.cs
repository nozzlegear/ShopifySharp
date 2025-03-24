#nullable enable
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ShopifySharp.Identifiers;

namespace ShopifySharp.Converters.SystemTextJson;

public class ShopifyGraphIdJsonConverter<T> : JsonConverter<T>
    where T : IShopifyGraphId
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var value = reader.GetString()!;

            // Find the constructor for this type
            var stringConstructor = typeToConvert.GetConstructor(types: [typeof(string)]);

            if (stringConstructor is null)
                throw new JsonException($"Could not find string constructor for type {typeToConvert.Name}.");

            return (T) stringConstructor.Invoke(parameters: [value]);
        }

        throw new JsonException($"Unexpected token type {reader.TokenType} when parsing {nameof(IShopifyGraphId)}.");
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.GraphId);
    }
}

