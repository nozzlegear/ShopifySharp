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
    /// A custom enum converter for varius enums which sets the default value 
    /// to T.Unkown when the value is null or does not exist.
    /// </summary>
    public class UnknownEnumConverter<T> : StringEnumConverter where T : struct
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            T parsed;

            if (!Enum.TryParse(reader.Value?.ToString() ?? "", true, out parsed))
            {
                return Enum.Parse(typeof(T), "Unknown", true);
            }

            return parsed;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            T parsed;
            T unknown = (T)Enum.Parse(typeof(T), "unknown", true);

            if (Enum.TryParse(value?.ToString(), out parsed))
            {
                if (parsed.Equals(unknown))
                {
                    writer.WriteNull();

                    return;
                }

                base.WriteJson(writer, value, serializer);

                return;
            }

            writer.WriteNull();

            //if (value == null ||
            //    !Enum.IsDefined(typeof(ShopifyRecurringChargeStatus), value) ||
            //    (Enum.IsDefined(typeof(ShopifyRecurringChargeStatus), value) && ((ShopifyRecurringChargeStatus)value) == ShopifyRecurringChargeStatus.Unknown))
            //{
            //    writer.WriteNull();
            //}
            //else
            //{
            //    base.WriteJson(writer, value, serializer);
            //}
        }
    }
}
