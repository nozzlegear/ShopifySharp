using Newtonsoft.Json;

namespace ShopifySharp.Infrastructure
{
    /// <summary>
    /// Contains JSON serialization settings and methods used by the rest of the ShopifySharp package.
    /// </summary>
    public static class Serializer
    {
        public static JsonSerializerSettings Settings { get; } = new JsonSerializerSettings()
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        public static JsonSerializer JsonSerializer { get; } = new JsonSerializer
        {
            DateParseHandling = DateParseHandling.DateTimeOffset
        };

        public static string Serialize(object data) => JsonConvert.SerializeObject(data, Settings);

        public static T Deserialize<T>(string json) => JsonConvert.DeserializeObject<T>(json, Settings);
    }
}