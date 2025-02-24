using System;
using Newtonsoft.Json;

namespace ShopifySharp.Converters;

/// <summary>
/// A custom boolean converter that converts False to null and null to False.
/// </summary>
public class FalseToNullConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return (objectType == typeof(string) || objectType == typeof(bool) || objectType == typeof(bool?));
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if (reader.Value is null || reader.Value?.ToString() == "")
            return false;

        if (reader.Value is not null && bool.TryParse(reader.Value.ToString(), out var output))
            return output;

        throw new JsonReaderException("Unable to convert JSON value.");
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        if (value is null)
        {
            writer.WriteNull();
            return;
        }

        if (!bool.TryParse(value.ToString(), out var parsedBool))
            throw new JsonWriterException("Unable to convert JSON value.");

        if (parsedBool == false)
            writer.WriteNull();
        else
            writer.WriteValue(true);
    }
}
