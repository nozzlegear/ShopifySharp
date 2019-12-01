using Newtonsoft.Json.Converters;
using System;
using Newtonsoft.Json;
using ShopifySharp.Enums;
using System.Runtime.Serialization;
using System.Reflection;
using System.Linq;

namespace ShopifySharp.Converters
{
    /// <summary>
    /// A custom converter that detects invalid dates and convert them to null instead of throwing an exception.
    /// In particular, FulfillmentEvent.EstimatedDeliveryAt has been observed to sometimes contain an invalid date
    /// e.g '0000-12-31T18:09:24-05:50', which is smaller than both DateTime.MinValue and DateTimeOffset.MinValue
    /// </summary>
    public class InvalidDateToNullConverter : IsoDateTimeConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value != null && reader.Value.ToString().StartsWith("0000"))
                return null;
            
            return base.ReadJson(reader, objectType, existingValue, serializer);
        }
    }
}
