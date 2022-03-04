using Newtonsoft.Json;
using ShopifySharp.Converters;
using System.Runtime.Serialization;

namespace ShopifySharp.Enums
{
    [JsonConverter(typeof(NullableEnumConverter<AuthorizationScope>))]
    public enum AuthorizationScope
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

        [EnumMember( Value = "read_all_orders" )]
        ReadAllOrders,

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
        WriteUsers,

        [EnumMember(Value = "read_checkouts")]
        ReadCheckouts,

        [EnumMember(Value = "write_checkouts")]
        WriteCheckouts,

        [EnumMember(Value = "read_reports")]
        ReadReports,

        [EnumMember(Value = "write_reports")]
        WriteReports,

        [EnumMember(Value = "read_price_rules")]
        ReadPriceRules,

        [EnumMember(Value = "write_price_rules")]
        WritePriceRules,

        [EnumMember(Value = "read_inventory")]
        ReadInventory,

        [EnumMember(Value = "write_inventory")]
        WriteInventory,

        [EnumMember(Value = "read_product_listings")]
        ReadProductListings,

        [EnumMember(Value = "read_collection_listings")]
        ReadCollectionListings,

        [EnumMember(Value = "read_draft_orders")]
        ReadDraftOrders,

        [EnumMember(Value = "write_draft_orders")]
        WriteDraftOrders,

        [EnumMember(Value = "write_merchant_managed_fulfillment_orders")]
        WriteMerchantManagedFulfillmentOrders,

        [EnumMember(Value = "read_merchant_managed_fulfillment_orders")]
        ReadMerchantManagedFulfillmentOrders,

        [EnumMember(Value = "read_assigned_fulfillment_orders")]
        ReadAssignedFulfillmentOrders,
        
        [EnumMember(Value = "write_assigned_fulfillment_orders")]
        WriteAssignedFulfillmentOrders,

        [EnumMember(Value = "read_marketing_events")]
        ReadMarketingEvents,

        [EnumMember(Value = "write_marketing_events")]
        WriteMarketingEvents,

        [EnumMember(Value = "read_resource_feedbacks")]
        ReadResourceFeedbacks,

        [EnumMember(Value = "write_resource_feedbacks")]
        WriteResourceFeedbacks,

        [EnumMember(Value = "unauthenticated_read_collection_listings")]
        UnauthenticatedReadCollectionListings,

        [EnumMember(Value = "unauthenticated_read_product_listings")]
        UnauthenticatedReadProductListings,

        [EnumMember(Value = "unauthenticated_write_checkouts")]
        UnauthenticatedWriteCheckouts,

        [EnumMember(Value = "unauthenticated_write_customers")]
        UnauthenticatedWriteCustomers,

        [EnumMember(Value = "unauthenticated_read_content")]
        UnauthenticatedReadContent,

        [EnumMember(Value = "read_locations")]
        ReadLocations,

        [EnumMember(Value = "read_translations")]
        ReadTranslations,

        [EnumMember(Value = "write_translations")]
        WriteTranslations,

        [EnumMember(Value = "read_discounts")]
        ReadDiscounts,

        [EnumMember(Value = "write_discounts")]
        WriteDiscounts
    }
}
