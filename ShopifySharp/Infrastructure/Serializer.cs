using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShopifySharp.Converters;
using System.Collections.Generic;

namespace ShopifySharp.Infrastructure
{
    /// <summary>
    /// Contains JSON serialization settings and methods used by the rest of the ShopifySharp package.
    /// </summary>
    public static class Serializer
    {
        public static JsonSerializerSettings CreateSettings()
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

        public static string Serialize(object data) => JsonConvert.SerializeObject(data, CreateSettings());

        public static T Deserialize<T>(string json, string rootElementPath = null, DateParseHandling? dateParseHandlingOverride = null)
        {
            var settings = CreateSettings();
            if (dateParseHandlingOverride != null)
                settings.DateParseHandling = dateParseHandlingOverride.Value;

            if (rootElementPath != null)
            {
                var jToken = JsonConvert.DeserializeObject<JToken>(json, settings);
                jToken = jToken.SelectToken(rootElementPath);
                return jToken.ToObject<T>(JsonSerializer.Create(settings));
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(json, settings);
            }
        }
    }
}