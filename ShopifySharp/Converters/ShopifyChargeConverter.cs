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
    /// A custom enum converter for <see cref="ShopifyChargeStatus"/> enums which sets the default value 
    /// to <see cref="ShopifyChargeStatus.Unknown"/> when the value is null or does not exist.
    /// </summary>
    public class ShopifyChargeConverter : StringEnumConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            ShopifyChargeStatus parsed;

            if (!Enum.TryParse(reader.Value?.ToString() ?? "", true, out parsed))
            {
                return ShopifyChargeStatus.Unknown;
            }

            return parsed;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null || 
                !Enum.IsDefined(typeof(ShopifyChargeStatus), value) || 
                (Enum.IsDefined(typeof(ShopifyChargeStatus), value) && ((ShopifyChargeStatus)value) == ShopifyChargeStatus.Unknown))
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
