#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ShopifySharp.Converters.SystemTextJson;

/// <summary>
/// Deserializes primitive values (integers, longs, booleans) as strings.
/// </summary>
public class PrimitiveStringConverter : JsonConverter<string?>
{
    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType switch
        {
            JsonTokenType.String => reader.GetString(),
            JsonTokenType.Number => reader.GetInt64().ToString(),
            JsonTokenType.True or JsonTokenType.False => reader.GetBoolean().ToString(),
            JsonTokenType.Null => null,
            _ => throw new JsonException($"Unexpected token {reader.TokenType} when parsing a string.")
        };
    }

    public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
    {
        if (value is null)
            writer.WriteNullValue();
        else
            writer.WriteStringValue(value);
    }
}

public class PrimitiveStringListConverter<TCollection>(JsonSerializerOptions options) : JsonConverter<TCollection>
    where TCollection : IEnumerable<string>
{
    private readonly PrimitiveStringConverter _primitiveStringConverter =
        options.GetConverter(typeof(PrimitiveStringConverter)) as PrimitiveStringConverter ?? new PrimitiveStringConverter();

    public override TCollection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var list = new List<string>();

        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException($"Unexpected token {reader.TokenType} when parsing a string list/array/enumerable.");

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
                break;

            // Use the PrimitiveStringConverter to read the token
            var value = _primitiveStringConverter.Read(ref reader, typeof(string), options);
            if (value is not null)
                list.Add(value);
        }

        if (typeToConvert == typeof(IEnumerable<string>))
            return (TCollection)(IEnumerable<string>)list;

        if (typeToConvert == typeof(IReadOnlyList<string>))
            return (TCollection)(IReadOnlyList<string>)list.AsReadOnly();

        throw new ArgumentException($"Unexpected conversion type \"{typeToConvert.FullName}\".", nameof(typeToConvert));
    }

    public override void Write(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        foreach (var item in value)
            _primitiveStringConverter.Write(writer, item, options);
        writer.WriteEndArray();
    }
}

public class PrimitiveStringConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeof(string) == typeToConvert
               || typeof(IEnumerable<string>).IsAssignableFrom(typeToConvert)
               || typeof(IReadOnlyList<string>).IsAssignableFrom(typeToConvert);
    }

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert == typeof(string))
            return new PrimitiveStringConverter();

        if (typeof(IEnumerable<string>).IsAssignableFrom(typeToConvert))
            return (JsonConverter)Activator.CreateInstance(
                typeof(PrimitiveStringListConverter<>).MakeGenericType(typeToConvert),
                options
            )!;

        return null;
    }
}
