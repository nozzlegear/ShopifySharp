#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ShopifySharp.Converters.SystemTextJson;

/// <summary>
/// Handles the conversion of Shopify's error extensions into a standard string/object dictionary.
/// </summary>
public class GraphErrorExtensionsValueConverter : ObjectDictionaryConverter
{
    private const string ConstructedDictionaryKey = "$value";

    public override IReadOnlyDictionary<string, object?> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // We've seen GraphErrorExtensions.Value exhibit three structures so far:
        // 1. {"value": {"foo": "bar", "baz": "bat"}}
        // 2. {"value": "foo"}
        // 3."{"value": [{ "foo": "bar", "baz": "bat" }]}
        // If #2, map the value into a dictionary using the (arbitrary) key "$value"
        // If #3, map the value into a dictionary using the [array_index]=[value]

        if (reader.TokenType == JsonTokenType.StartObject)
            return base.Read(ref reader, typeToConvert, options);

        if (reader.TokenType == JsonTokenType.StartArray)
        {
            var itemIndex = 0;
            var dict = new Dictionary<string, object?>();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                    break;

                if (reader.TokenType == JsonTokenType.StartObject)
                {
                    var subDict = base.Read(ref reader, typeToConvert, options);
                    if (subDict.Count == 0)
                        continue;
                    dict.Add(itemIndex.ToString(),subDict);
                }
                else
                {
                    dict.Add(itemIndex.ToString(), ReadValue(ref reader));
                }

                itemIndex++;
            }

            return dict;
        }

        return new Dictionary<string, object?>() { { ConstructedDictionaryKey, ReadValue(ref reader) } }.ToReadOnlyDictionary();
    }
}
