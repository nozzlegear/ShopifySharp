using Newtonsoft.Json;
using ShopifySharp.Converters;
using System.Runtime.Serialization;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// A topic for a <see cref="ShopifyWebhook"/>
    /// </summary>
    [JsonConverter(typeof(NullableEnumConverter<ShopifyWebhookTopic>))]
    public enum ShopifyWebhookTopic
    {
        /// <summary>
        /// When an order has been created.
        /// </summary>
        [EnumMember(Value = "orders/create")]
        OrderCreated,

        /// <summary>
        /// When an order has been deleted.
        /// </summary>
        [EnumMember(Value = "orders/delete")]
        OrderDeleted,

        /// <summary>
        /// When an order has been updated.
        /// </summary>
        [EnumMember(Value ="orders/updated")]
        OrderUpdated,

        /// <summary>
        /// When an order has been paid.
        /// </summary>
        [EnumMember(Value = "orders/paid")]
        OrderPaid,

        /// <summary>
        /// When an order has been cancelled.
        /// </summary>
        [EnumMember(Value = "orders/cancelled")]
        OrderCancelled,

        /// <summary>
        /// When an order has been fulfilled.
        /// </summary>
        [EnumMember(Value = "orders/fulfilled")]
        OrderFulfilled,

        /// <summary>
        /// When an order has been partially fulfilled.
        /// </summary>
        [EnumMember(Value = "orders/partially_fulfilled")]
        OrderPartiallyFulfilled,

        /// <summary>
        /// When a transaction has been created.
        /// </summary>
        [EnumMember(Value = "order_transactions/create")]
        OrderTransactionCreated,

        /// <summary>
        /// When a cart has been created.
        /// </summary>
        [EnumMember(Value = "carts/create")]
        CartCreated,

        /// <summary>
        /// When a cart has been updated.
        /// </summary>
        [EnumMember(Value = "carts/update")]
        CartUpdated,

        /// <summary>
        /// When a checkout has been created.
        /// </summary>
        [EnumMember(Value = "checkouts/create")]
        CheckoutCreated,

        /// <summary>
        /// When a checkout has been updated.
        /// </summary>
        [EnumMember(Value = "checkouts/update")]
        CheckoutUpdated,

        /// <summary>
        /// When a checkout has been deleted.
        /// </summary>
        [EnumMember(Value = "checkouts/delete")]
        CheckoutDeleted,

        /// <summary>
        /// When a refund has been created.
        /// </summary>
        [EnumMember(Value = "refunds/create")]
        RefundCreated,

        /// <summary>
        /// When a product has been created.
        /// </summary>
        [EnumMember(Value = "products/create")]
        ProductCreated,

        /// <summary>
        /// When a product has been updated.
        /// </summary>
        [EnumMember(Value = "products/update")]
        ProductUpdated,

        /// <summary>
        /// When a product has been deleted.
        /// </summary>
        [EnumMember(Value = "products/delete")]
        ProductDeleted,

        /// <summary>
        /// When a collection has been created.
        /// </summary>
        [EnumMember(Value = "collections/create")]
        CollectionCreated,
        
        /// <summary>
        /// When a collection has been updated.
        /// </summary>
        [EnumMember(Value = "collections/update")]
        CollectionUpdated,

        /// <summary>
        /// When a collection has been deleted.
        /// </summary>
        [EnumMember(Value = "collections/delete")]
        CollectionDeleted,

        /// <summary>
        /// When a customer group has been created.
        /// </summary>
        [EnumMember(Value = "customer_groups/create")]
        CustomerGroupCreated,

        /// <summary>
        /// When a customer group has been updated.
        /// </summary>
        [EnumMember(Value = "customer_groups/update")]
        CustomerGroupUpdated,

        /// <summary>
        /// When a customer group has been deleted.
        /// </summary>
        [EnumMember(Value = "customer_groups/delete")]
        CustomerGroupDeleted,

        /// <summary>
        /// When a customer has been created.
        /// </summary>
        [EnumMember(Value = "customers/create")]
        CustomerCreated,

        /// <summary>
        /// When a customer has been enabled.
        /// </summary>
        [EnumMember(Value = "customers/enable")]
        CustomerEnabled,

        /// <summary>
        /// When a customer has been disabled.
        /// </summary>
        [EnumMember(Value = "customers/disable")]
        CustomerDisabled,

        /// <summary>
        /// When a customer has been updated.
        /// </summary>
        [EnumMember(Value = "customers/update")]
        CustomerUpdated,

        /// <summary>
        /// When a customer has been deleted.
        /// </summary>
        [EnumMember(Value = "customers/delete")]
        CustomerDeleted,

        /// <summary>
        /// When a fulfillment has been created.
        /// </summary>
        [EnumMember(Value = "fulfillments/create")]
        FulfillmentCreated,

        /// <summary>
        /// When a fulfillment has been updated.
        /// </summary>
        [EnumMember(Value = "fulfillments/update")]
        FulfillmentUpdated,

        /// <summary>
        /// When a shop has been updated.
        /// </summary>
        [EnumMember(Value = "shop/update")]
        ShopUpdated,

        /// <summary>
        /// When a dispute has been created.
        /// </summary>
        [EnumMember(Value = "disputes/create")]
        DisputeCreated,

        /// <summary>
        /// When a dispute has been updated.
        /// </summary>
        [EnumMember(Value = "disputes/update")]
        DisputeUpdated,

        /// <summary>
        /// When an app has been uninstalled.
        /// </summary>
        [EnumMember(Value = "app/uninstalled")]
        AppUninstalled
    }
}
