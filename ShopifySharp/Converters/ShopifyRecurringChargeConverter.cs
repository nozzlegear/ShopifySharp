using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ShopifySharp.Enums;

namespace ShopifySharp.Converters
{
    /// <summary>
    /// A custom enum converter for <see cref="ShopifyRecurringChargeStatus"/> enums which sets the default value 
    /// to <see cref="ShopifyRecurringChargeStatus.Unknown"/> when the value is null or does not exist.
    /// </summary>
    public class ShopifyRecurringChargeConverter : StringEnumConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (string.IsNullOrEmpty(reader.Value?.ToString()))
                return ShopifyRecurringChargeStatus.Unknown;

            return base.ReadJson(reader, objectType, existingValue, serializer);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null || 
                !Enum.IsDefined(typeof(ShopifyRecurringChargeStatus), value) || 
                (Enum.IsDefined(typeof(ShopifyRecurringChargeStatus), value) && ((ShopifyRecurringChargeStatus)value) == ShopifyRecurringChargeStatus.Unknown))
            {
                writer.WriteNull();
            }
            else
            {
                base.WriteJson(writer, value, serializer);
            }
        }
    }
}
