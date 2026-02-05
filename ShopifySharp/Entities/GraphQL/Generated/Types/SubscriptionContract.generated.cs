#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A subscription contract that defines recurring purchases for a customer. Each
/// contract specifies what products to deliver, when to bill and ship them, and at what price.
/// The contract includes [`SubscriptionBillingPolicy`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SubscriptionBillingPolicy) and [`SubscriptionDeliveryPolicy`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SubscriptionDeliveryPolicy)
/// that control the frequency of charges and fulfillments. [`SubscriptionLine`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SubscriptionLine)
/// items define the products, quantities, and pricing for each recurring
/// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order). The
/// contract tracks [`SubscriptionBillingAttempt`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SubscriptionBillingAttempt)
/// records, payment status, and generated orders throughout its lifecycle.
/// [`App`](https://shopify.dev/docs/api/admin-graphql/latest/objects/App) instances
/// manage contracts through various status transitions including active, paused,
/// failed, cancelled, or expired states.
/// Learn more about [building subscription contracts](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/contracts/build-a-subscription-contract)
/// and [updating subscription contracts](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/contracts/update-a-subscription-contract).
/// </summary>
public record SubscriptionContract : IGraphQLObject, INode, ISubscriptionContractBase
{
    /// <summary>
    /// The subscription app that the subscription contract is registered to.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The URL of the subscription contract page on the subscription app.
    /// </summary>
    [JsonPropertyName("appAdminUrl")]
    public string? appAdminUrl { get; set; } = null;

    /// <summary>
    /// The list of billing attempts associated with the subscription contract.
    /// </summary>
    [JsonPropertyName("billingAttempts")]
    public SubscriptionBillingAttemptConnection? billingAttempts { get; set; } = null;

    /// <summary>
    /// The billing policy associated with the subscription contract.
    /// </summary>
    [JsonPropertyName("billingPolicy")]
    public SubscriptionBillingPolicy? billingPolicy { get; set; } = null;

    /// <summary>
    /// The date and time when the subscription contract was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The currency that's used for the subscription contract.
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
    /// The customer payment method that's used for the subscription contract.
    /// </summary>
    [JsonPropertyName("customerPaymentMethod")]
    public CustomerPaymentMethod? customerPaymentMethod { get; set; } = null;

    /// <summary>
    /// The delivery method for each billing of the subscription contract.
    /// </summary>
    [JsonPropertyName("deliveryMethod")]
    public SubscriptionDeliveryMethod? deliveryMethod { get; set; } = null;

    /// <summary>
    /// The delivery policy associated with the subscription contract.
    /// </summary>
    [JsonPropertyName("deliveryPolicy")]
    public SubscriptionDeliveryPolicy? deliveryPolicy { get; set; } = null;

    /// <summary>
    /// The delivery price for each billing of the subscription contract.
    /// </summary>
    [JsonPropertyName("deliveryPrice")]
    public MoneyV2? deliveryPrice { get; set; } = null;

    /// <summary>
    /// The list of subscription discounts associated with the subscription contract.
    /// </summary>
    [JsonPropertyName("discounts")]
    public SubscriptionManualDiscountConnection? discounts { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The last billing error type of the contract.
    /// </summary>
    [JsonPropertyName("lastBillingAttemptErrorType")]
    public SubscriptionContractLastBillingErrorType? lastBillingAttemptErrorType { get; set; } = null;

    /// <summary>
    /// The current status of the last payment.
    /// </summary>
    [JsonPropertyName("lastPaymentStatus")]
    public SubscriptionContractLastPaymentStatus? lastPaymentStatus { get; set; } = null;

    /// <summary>
    /// The number of lines associated with the subscription contract.
    /// </summary>
    [JsonPropertyName("lineCount")]
    [Obsolete("Use `linesCount` instead.")]
    public int? lineCount { get; set; } = null;

    /// <summary>
    /// The list of subscription lines associated with the subscription contract.
    /// </summary>
    [JsonPropertyName("lines")]
    public SubscriptionLineConnection? lines { get; set; } = null;

    /// <summary>
    /// The number of lines associated with the subscription contract.
    /// </summary>
    [JsonPropertyName("linesCount")]
    public Count? linesCount { get; set; } = null;

    /// <summary>
    /// The next billing date for the subscription contract. This field is managed by the apps.
    ///         Alternatively you can utilize our
    ///         [Billing Cycles APIs](https://shopify.dev/docs/apps/selling-strategies/subscriptions/billing-cycles),
    ///         which provide auto-computed billing dates and additional functionalities.
    /// </summary>
    [JsonPropertyName("nextBillingDate")]
    public DateTimeOffset? nextBillingDate { get; set; } = null;

    /// <summary>
    /// The note field that will be applied to the generated orders.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// A list of the subscription contract's orders.
    /// </summary>
    [JsonPropertyName("orders")]
    public OrderConnection? orders { get; set; } = null;

    /// <summary>
    /// The order from which this contract originated.
    /// </summary>
    [JsonPropertyName("originOrder")]
    public Order? originOrder { get; set; } = null;

    /// <summary>
    /// The revision id of the contract.
    /// </summary>
    [JsonPropertyName("revisionId")]
    public ulong? revisionId { get; set; } = null;

    /// <summary>
    /// The current status of the subscription contract.
    /// </summary>
    [JsonPropertyName("status")]
    public SubscriptionContractSubscriptionStatus? status { get; set; } = null;

    /// <summary>
    /// The date and time when the subscription contract was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}