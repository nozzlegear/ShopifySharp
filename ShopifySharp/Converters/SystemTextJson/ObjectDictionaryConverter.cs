#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using ShopifySharp.Infrastructure.Serialization.Json;

namespace ShopifySharp.Converters.SystemTextJson;

/// <summary>
/// A custom JSON converter for dictionaries with <c>string</c> keys and <c>object</c> values. This converter is necessary
/// because System.Text.Json does not deserialize json values into their underlying CLR types when using <c>object</c>;
/// rather, System.Text.Json deserializes json values into <see cref="IJsonElement"/>, which is unexpected behavior.
/// </summary>
/// <remarks>
/// This converter handles deserialization of dictionary values into appropriate CLR types such as:
/// <list type="bullet">
/// <item><description><c>string</c> for JSON string values.</description></item>
/// <item><description><c>long</c> or <c>double</c> for JSON number values.</description></item>
/// <item><description><c>bool</c> for JSON boolean values.</description></item>
/// <item><description><c>null</c> for JSON null values.</description></item>
/// <item><description><c>SystemJsonElement</c> for unsupported or complex JSON structures.</description></item>
/// </list>
/// </remarks>
public class ObjectDictionaryConverter : JsonConverter<IReadOnlyDictionary<string, object?>>
{
    public override IReadOnlyDictionary<string, object?> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new Dictionary<string, object?>();

        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException("Expected StartObject token");

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
                return result;

            if (reader.TokenType != JsonTokenType.PropertyName)
                throw new JsonException("Expected PropertyName token");

            var propertyName = reader.GetString();

            // Always read even if the property name is null, to ensure we advance the reader past the property value for the next loop
            reader.Read();

            if (propertyName is null)
                continue;

            object? value = reader.TokenType switch
            {
                JsonTokenType.String => reader.GetString(),
                JsonTokenType.Number => reader.TryGetInt64(out var l) ? l : reader.GetDouble(),
                JsonTokenType.True => true,
                JsonTokenType.False => false,
                JsonTokenType.Null => null,
                _ => new SystemJsonElement(JsonDocument.ParseValue(ref reader).RootElement.Clone())
            };

            result[propertyName] = value;
        }

        throw new JsonException("Expected EndObject token");
    }

    public override void Write(Utf8JsonWriter writer, IReadOnlyDictionary<string, object?> value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
