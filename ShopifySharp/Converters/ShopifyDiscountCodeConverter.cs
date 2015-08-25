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
    /// A custom enum converter for <see cref="ShopifyDiscountCodeType"/> enums which sets the default value to <see cref="ShopifyDiscountCodeType.None"/> when the value is null.
    /// </summary>
    public class ShopifyDiscountCodeConverter : StringEnumConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (string.IsNullOrEmpty(reader.Value?.ToString()))
                return ShopifyDiscountCodeType.None;

            return base.ReadJson(reader, objectType, existingValue, serializer);
        }
    }
}
