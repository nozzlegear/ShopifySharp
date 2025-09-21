#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The `SubscriptionDraft` object represents a draft version of a
/// [subscription contract](https://shopify.dev/docs/api/admin-graphql/latest/objects/SubscriptionContract)
/// before it's committed. It serves as a staging area for making changes to an existing subscription or creating
/// a new one. The draft allows you to preview and modify various aspects of a subscription before applying the changes.
/// Use the `SubscriptionDraft` object to:
/// - Add, remove, or modify subscription lines and their quantities
/// - Manage discounts (add, remove, or update manual and code-based discounts)
/// - Configure delivery options and shipping methods
/// - Set up billing and delivery policies
/// - Manage customer payment methods
/// - Add custom attributes and notes to generated orders
/// - Configure billing cycles and next billing dates
/// - Preview the projected state of the subscription
/// Each `SubscriptionDraft` object maintains a projected state that shows how the subscription will look after the changes
/// are committed. This allows you to preview the impact of your modifications before applying them. The draft can be
/// associated with an existing subscription contract (for modifications) or used to create a new subscription.
/// The draft remains in a draft state until it's committed, at which point the changes are applied to the subscription
/// contract and the draft is no longer accessible.
/// Learn more about
/// [how subscription contracts work](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/contracts)
/// and how to [build](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/contracts/build-a-subscription-contract),
/// [update](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/contracts/update-a-subscription-contract), and
/// [combine](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/contracts/combine-subscription-contracts) subscription contracts.
/// </summary>
public record SubscriptionDraft : IGraphQLObject, INode
{
    /// <summary>
    /// The billing cycle that the subscription contract will be associated with.
    /// </summary>
    [JsonPropertyName("billingCycle")]
    public SubscriptionBillingCycle? billingCycle { get; set; } = null;

    /// <summary>
    /// The billing policy for the subscription contract.
    /// </summary>
    [JsonPropertyName("billingPolicy")]
    public SubscriptionBillingPolicy? billingPolicy { get; set; } = null;

    /// <summary>
    /// The billing cycles of the contracts that will be concatenated to the subscription contract.
    /// </summary>
    [JsonPropertyName("concatenatedBillingCycles")]
    public SubscriptionBillingCycleConnection? concatenatedBillingCycles { get; set; } = null;

    /// <summary>
    /// The currency used for the subscription contract.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public CurrencyCode? currencyCode { get; set; } = null;

    /// <summary>
    /// A list of the custom attributes to be added to the generated orders.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<Attribute>? customAttributes { get; set; } = null;

    /// <summary>
    /// The customer to whom the subscription contract belongs.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; } = null;

    /// <summary>
    /// The customer payment method used for the subscription contract.
    /// </summary>
    [JsonPropertyName("customerPaymentMethod")]
    public CustomerPaymentMethod? customerPaymentMethod { get; set; } = null;

    /// <summary>
    /// The delivery method for each billing of the subscription contract.
    /// </summary>
    [JsonPropertyName("deliveryMethod")]
    public SubscriptionDeliveryMethod? deliveryMethod { get; set; } = null;

    /// <summary>
    /// The available delivery options for a given delivery address. Returns `null` for pending requests.
    /// </summary>
    [JsonPropertyName("deliveryOptions")]
    public SubscriptionDeliveryOptionResult? deliveryOptions { get; set; } = null;

    /// <summary>
    /// The delivery policy for the subscription contract.
    /// </summary>
    [JsonPropertyName("deliveryPolicy")]
    public SubscriptionDeliveryPolicy? deliveryPolicy { get; set; } = null;

    /// <summary>
    /// The delivery price for each billing the subscription contract.
    /// </summary>
    [JsonPropertyName("deliveryPrice")]
    public MoneyV2? deliveryPrice { get; set; } = null;

    /// <summary>
    /// The list of subscription discounts which will be associated with the subscription contract.
    /// </summary>
    [JsonPropertyName("discounts")]
    public SubscriptionDiscountConnection? discounts { get; set; } = null;

    /// <summary>
    /// The list of subscription discounts to be added to the subscription contract.
    /// </summary>
    [JsonPropertyName("discountsAdded")]
    public SubscriptionDiscountConnection? discountsAdded { get; set; } = null;

    /// <summary>
    /// The list of subscription discounts to be removed from the subscription contract.
    /// </summary>
    [JsonPropertyName("discountsRemoved")]
    public SubscriptionDiscountConnection? discountsRemoved { get; set; } = null;

    /// <summary>
    /// The list of subscription discounts to be updated on the subscription contract.
    /// </summary>
    [JsonPropertyName("discountsUpdated")]
    public SubscriptionDiscountConnection? discountsUpdated { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The list of subscription lines which will be associated with the subscription contract.
    /// </summary>
    [JsonPropertyName("lines")]
    public SubscriptionLineConnection? lines { get; set; } = null;

    /// <summary>
    /// The list of subscription lines to be added to the subscription contract.
    /// </summary>
    [JsonPropertyName("linesAdded")]
    public SubscriptionLineConnection? linesAdded { get; set; } = null;

    /// <summary>
    /// The list of subscription lines to be removed from the subscription contract.
    /// </summary>
    [JsonPropertyName("linesRemoved")]
    public SubscriptionLineConnection? linesRemoved { get; set; } = null;

    /// <summary>
    /// The next billing date for the subscription contract.
    /// </summary>
    [JsonPropertyName("nextBillingDate")]
    public DateTime? nextBillingDate { get; set; } = null;

    /// <summary>
    /// The note field that will be applied to the generated orders.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The original subscription contract.
    /// </summary>
    [JsonPropertyName("originalContract")]
    public SubscriptionContract? originalContract { get; set; } = null;

    /// <summary>
    /// Available Shipping Options for a given delivery address. Returns NULL for pending requests.
    /// </summary>
    [JsonPropertyName("shippingOptions")]
    [Obsolete("Use `deliveryOptions` instead.")]
    public SubscriptionShippingOptionResult? shippingOptions { get; set; } = null;

    /// <summary>
    /// The current status of the subscription contract.
    /// </summary>
    [JsonPropertyName("status")]
    public SubscriptionContractSubscriptionStatus? status { get; set; } = null;
}