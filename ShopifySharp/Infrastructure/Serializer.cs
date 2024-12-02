using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShopifySharp.Converters;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonConverter = Newtonsoft.Json.JsonConverter;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace ShopifySharp.Infrastructure;

/// <summary>
/// Contains JSON serialization settings and methods used by the rest of the ShopifySharp package.
/// </summary>
public static class Serializer
{
    public static JsonSerializerSettings CreateNewtonsoftSettings()
    {
        return new JsonSerializerSettings
        {
            DateParseHandling = DateParseHandling.DateTimeOffset,
            NullValueHandling = NullValueHandling.Ignore,
            Converters = new List<JsonConverter>
            {
                new InvalidDateConverter()
            }
        };
    }

    // TODO: investigate standardizing the ShopifySharp.GraphQL.Serializer.Options defaults with these defaults
    internal static readonly JsonSerializerOptions GraphSerializerOptions = new()
    {
        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        Converters =
        {
            new JsonStringEnumConverter()
        },
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    public static string Serialize(object data) => JsonConvert.SerializeObject(data, CreateNewtonsoftSettings());

    public static T Deserialize<T>(string json, string rootElementPath = null, DateParseHandling? dateParseHandlingOverride = null)
    {
        if (typeof(T) == typeof(System.Text.Json.JsonDocument))
            return DeserializeWithSystemTextJson<T>(json);
        else
            return DeserializeWithNewtonsoft<T>(json, rootElementPath, dateParseHandlingOverride);
    }

    /// <remarks>This method is not used internally by ShopifySharp but can be used to deserialize webhook JSON payloads into objects</remarks>
    public static object Deserialize(string json, Type objectType)
    {
        var settings = CreateNewtonsoftSettings();
        return JsonConvert.DeserializeObject(json, objectType, settings);
    }

    private static T DeserializeWithNewtonsoft<T>(string json, string rootElementPath, DateParseHandling? dateParseHandlingOverride)
    {
        var settings = CreateNewtonsoftSettings();
        if (dateParseHandlingOverride != null)
            settings.DateParseHandling = dateParseHandlingOverride.Value;

        if (rootElementPath != null)
        {
            var jToken = JsonConvert.DeserializeObject<JToken>(json, settings);
            jToken = jToken.SelectToken(rootElementPath);
            return jToken.ToObject<T>(JsonSerializer.Create(settings));
        }

        return JsonConvert.DeserializeObject<T>(json, settings);
    }

    private static T DeserializeWithSystemTextJson<T>(string json)
    {
        return System.Text.Json.JsonSerializer.Deserialize<T>(json);
    }
}
