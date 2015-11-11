using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShopifySharp.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// Specifies how a theme is being used within the shop.
    /// </summary>
    [JsonConverter(typeof(NullableEnumConverter<ShopifyThemeRole>))]
    public enum ShopifyThemeRole
    {
        /// <summary>
        /// This theme can be seen by customers when visiting the shop in a desktop browser.
        /// </summary>
        [EnumMember(Value = "main")]
        Main,

        /// <summary>
        /// This theme cannot currently be seen by customers.
        /// </summary>
        [EnumMember(Value = "unpublished")]
        Unpublished
    }
}
