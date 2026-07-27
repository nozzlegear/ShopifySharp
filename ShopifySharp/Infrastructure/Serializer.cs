using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShopifySharp.Converters;
using ShopifySharp.Converters.SystemTextJson;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
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

    /// <summary>
    /// JSON serializer options specifically for serializing GraphQL request bodies (variables, query, etc.)
    /// sent to the Shopify API. These options suppress polymorphism (<c>__typename</c>) for all types,
    /// because Shopify's API rejects <c>__typename</c> in request payloads.
    /// </summary>
    internal static readonly JsonSerializerOptions GraphRequestSerializerOptions = new()
    {
        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        TypeInfoResolver = new DefaultJsonTypeInfoResolver
        {
            Modifiers =
            {
                typeInfo =>
                {
                    // Suppress polymorphic discriminator (e.g. __typename) during serialization.
                    // This prevents any type from emitting __typename when serialized as part of
                    // a GraphQL request (e.g. variables).
                    typeInfo.PolymorphismOptions = null;
                }
            }
        },
        Converters =
        {
            new JsonStringEnumConverter()
        },
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    /// <summary>
    /// JSON serializer options for deserializing GraphQL API responses. These options preserve
    /// polymorphism (<c>__typename</c>) so that polymorphic response types (e.g. interfaces, unions)
    /// can be correctly deserialized.
    /// </summary>
    internal static readonly JsonSerializerOptions GraphSerializerOptions = new()
    {
        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        Converters =
        {
            new JsonStringEnumConverter()
        },
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        // Note: No TypeInfoResolver modifier here, so __typename is preserved for polymorphic types
    };

    internal static readonly JsonSerializerOptions RestSerializerOptions = new()
    {
        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        Converters =
        {
            new JsonStringEnumConverter()
        },
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
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
