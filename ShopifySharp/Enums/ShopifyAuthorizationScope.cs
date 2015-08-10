using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShopifyAuthorizationScope
    {
        [EnumMember(Value = "read_content")]
        ReadContent,

        [EnumMember(Value = "write_content")]
        WriteContent,

        [EnumMember(Value = "read_themes")]
        ReadThemes,

        [EnumMember(Value = "write_themes")]
        WriteThemes,

        [EnumMember(Value = "read_products")]
        ReadProducts,

        [EnumMember(Value = "write_products")]
        WriteProducts,

        [EnumMember(Value = "read_customers")]
        ReadCustomers,

        [EnumMember(Value = "write_customers")]
        WriteCustomers,

        [EnumMember(Value = "read_orders")]
        ReadOrders,

        [EnumMember(Value = "write_orders")]
        WriteOrders,

        [EnumMember(Value = "read_script_tags")]
        ReadScriptTags,

        [EnumMember(Value = "write_script_tags")]
        WriteScriptTags,

        [EnumMember(Value = "read_fulfillments")]
        ReadFulfillments,

        [EnumMember(Value = "write_fulfillments")]
        WriteFulfillments,

        [EnumMember(Value = "read_shipping")]
        ReadShipping,

        [EnumMember(Value = "write_shipping")]
        WriteShipping
    }
}
