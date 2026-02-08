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
/// Represents subscription contract common fields.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(SubscriptionBillingCycleEditedContract), typeDiscriminator: "SubscriptionBillingCycleEditedContract")]
[JsonDerivedType(typeof(SubscriptionContract), typeDiscriminator: "SubscriptionContract")]
public interface ISubscriptionContractBase : IGraphQLObject
{
    /// <summary>
    /// The subscription app that the subscription contract is registered to.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; }

    /// <summary>
    /// The URL of the subscription contract page on the subscription app.
    /// </summary>
    [JsonPropertyName("appAdminUrl")]
    public string? appAdminUrl { get; set; }

    /// <summary>
    /// The currency that's used for the subscription contract.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public CurrencyCode? currencyCode { get; set; }

    /// <summary>
    /// A list of the custom attributes to be added to the generated orders.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<Attribute>? customAttributes { get; set; }

    /// <summary>
    /// The customer to whom the subscription contract belongs.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; }

    /// <summary>
    /// The customer payment method that's used for the subscription contract.
    /// </summary>
    [JsonPropertyName("customerPaymentMethod")]
    public CustomerPaymentMethod? customerPaymentMethod { get; set; }

    /// <summary>
    /// The delivery method for each billing of the subscription contract.
    /// </summary>
    [JsonPropertyName("deliveryMethod")]
    public SubscriptionDeliveryMethod? deliveryMethod { get; set; }

    /// <summary>
    /// The delivery price for each billing of the subscription contract.
    /// </summary>
    [JsonPropertyName("deliveryPrice")]
    public MoneyV2? deliveryPrice { get; set; }

    /// <summary>
    /// The list of subscription discounts associated with the subscription contract.
    /// </summary>
    [JsonPropertyName("discounts")]
    public SubscriptionManualDiscountConnection? discounts { get; set; }

    /// <summary>
    /// The number of lines associated with the subscription contract.
    /// </summary>
    [JsonPropertyName("lineCount")]
    [Obsolete("Use `linesCount` instead.")]
    public int? lineCount { get; set; }

    /// <summary>
    /// The list of subscription lines associated with the subscription contract.
    /// </summary>
    [JsonPropertyName("lines")]
    public SubscriptionLineConnection? lines { get; set; }

    /// <summary>
    /// The number of lines associated with the subscription contract.
    /// </summary>
    [JsonPropertyName("linesCount")]
    public Count? linesCount { get; set; }

    /// <summary>
    /// The note field that will be applied to the generated orders.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; }

    /// <summary>
    /// A list of the subscription contract's orders.
    /// </summary>
    [JsonPropertyName("orders")]
    public OrderConnection? orders { get; set; }

    /// <summary>
    /// The date and time when the subscription contract was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; }
}