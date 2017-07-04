using Newtonsoft.Json;
using ShopifySharp.Converters;
using System.Runtime.Serialization;

namespace ShopifySharp.Enums
{
    [JsonConverter(typeof(NullableEnumConverter<ShopifyAuthorizationScope>))]
    public enum ShopifyAuthorizationScope
    {
        [EnumMember(Value = "read_abandoned_checkouts")]
        ReadAbandonedCheckouts,

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
        WriteShipping,

        [EnumMember(Value = "read_analytics")]
        ReadAnalytics,

        [EnumMember(Value = "read_users")]
        ReadUsers,

        [EnumMember(Value = "write_users")]
        WriteUsers
    }
}
