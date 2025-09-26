#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create a Subscription Contract.
/// </summary>
public record SubscriptionContractAtomicCreateInput : GraphQLInputObject<SubscriptionContractAtomicCreateInput>
{
    /// <summary>
    /// The attributes used as input for the Subscription Draft.
    /// </summary>
    [JsonPropertyName("contract")]
    public SubscriptionDraftInput? contract { get; set; } = null;

    /// <summary>
    /// The currency used for the subscription contract.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public CurrencyCode? currencyCode { get; set; } = null;

    /// <summary>
    /// The ID of the customer to associate with the subscription contract.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? customerId { get; set; } = null;

    /// <summary>
    /// A list of discount redeem codes to apply to the subscription contract.
    /// </summary>
    [JsonPropertyName("discountCodes")]
    public ICollection<string>? discountCodes { get; set; } = null;

    /// <summary>
    /// A list of new Subscription Lines.
    /// </summary>
    [JsonPropertyName("lines")]
    public ICollection<SubscriptionAtomicLineInput>? lines { get; set; } = null;

    /// <summary>
    /// The next billing date for the subscription contract.This field is independent
    /// of billing cycles.It stores metadata set by the apps, and thus not managed by
    /// Shopify.It can be queried from subscriptionContract.nextBillingDate.
    /// </summary>
    [JsonPropertyName("nextBillingDate")]
    public DateTime? nextBillingDate { get; set; } = null;
}