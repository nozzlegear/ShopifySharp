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
    /// A custom enum converter for all enums which returns the value 
    /// as null when the value is null or does not exist.
    /// </summary>
    public class NullableEnumConverter<T> : StringEnumConverter where T : struct
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            T parsed;
            
            if (!Enum.TryParse(reader.Value?.ToString() ?? "", true, out parsed))
            {
                //Despite using EnumMember, any enum with an '_' value fails the TryParse and IsDefined
                //checks. Remove underscores and try to match again before returning null.

                if (!Enum.TryParse(reader.Value?.ToString().Replace("_", "") ?? "", true, out parsed))
                {
                    return null;
                }
            }

            return parsed;
        }
    }
}
