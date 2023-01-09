using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShopifySharp.Converters;
using System;
using System.Collections.Generic;

namespace ShopifySharp.Infrastructure
{
    /// <summary>
    /// Contains JSON serialization settings and methods used by the rest of the ShopifySharp package.
    /// </summary>
    public static class Serializer
    {
        private static JsonSerializerSettings CreateSettings()
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

        public static object Deserialize(string json, Type objectType) => JsonConvert.DeserializeObject(json, objectType, CreateSettings());

        public static T Deserialize<T>(string json) => JsonConvert.DeserializeObject<T>(json, CreateSettings());

        public static T Deserialize<T>(string json, string rootElementPath)
        {
            var jToken = Deserialize<JToken>(json).SelectToken(rootElementPath);
            return jToken.ToObject<T>(JsonSerializer.Create(CreateSettings()));
        }
    }
}