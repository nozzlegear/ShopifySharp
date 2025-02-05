using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ShopifySharp.Converters.SystemTextJson;

/// <summary>
/// Deserializes primitive values (integers, longs, booleans) as strings.
/// </summary>
public class PrimitiveStringConverter : JsonConverter<string>
{
    // public override bool HandleNull => false;

    public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType switch
        {
            JsonTokenType.String => reader.GetString(),
            JsonTokenType.Number => reader.GetInt64().ToString(),
            JsonTokenType.True or JsonTokenType.False => reader.GetBoolean().ToString(),
            _ => throw new JsonException($"Unexpected token {reader.TokenType} when parsing a string.")
        };
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}

public class PrimitiveStringListConverter<TCollection>(JsonSerializerOptions options) : JsonConverter<TCollection>
    where TCollection : IEnumerable<string>
{
    private PrimitiveStringConverter GetPrimitiveStringConverter(JsonSerializerOptions options) =>
        (PrimitiveStringConverter)options.GetConverter(typeof(PrimitiveStringConverter));

    public override TCollection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var converter = GetPrimitiveStringConverter(options);
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options)
    {
        var converter = GetPrimitiveStringConverter(options);
        throw new NotImplementedException();
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

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeof(string) == typeToConvert)
            return new PrimitiveStringConverter();

        throw new NotImplementedException();
    }
}
