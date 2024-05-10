using Newtonsoft.Json.Converters;
using System;
using Newtonsoft.Json;

namespace ShopifySharp.Converters;

/// <summary>
/// A custom converter that detects invalid dates and convert them to null instead of throwing an exception.
/// In particular, FulfillmentEvent.EstimatedDeliveryAt has been observed to sometimes contain an invalid date
/// e.g '0000-12-31T18:09:24-05:50', which is smaller than both DateTime.MinValue and DateTimeOffset.MinValue
/// UPDATE October 2022:
/// This API bug has been encountered in several additional API fields, such as transaction.processed_at, customer.accepts_marketing_updated_at and customer.email_marketing_consent.consent_updated_at
/// See https://github.com/nozzlegear/ShopifySharp/issues/803
/// This converter is applied to all date properties because:
/// *It seems to can start occurring on multiple any date fields
/// *The impact of not handling is quite severe. ShopifySharp would fail to deserialize and return an error
/// </summary>
public class InvalidDateConverter : IsoDateTimeConverter
{
    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if (reader.Value != null && reader.Value.ToString().StartsWith("0000-"))
            return null;
            
        return base.ReadJson(reader, objectType, existingValue, serializer);
    }
}