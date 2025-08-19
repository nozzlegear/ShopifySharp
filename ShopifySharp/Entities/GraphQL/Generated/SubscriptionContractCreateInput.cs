#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to create a Subscription Contract.
/// </summary>
public record SubscriptionContractCreateInput : GraphQLInputObject<SubscriptionContractCreateInput>
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
    /// The next billing date for the subscription contract.
    /// </summary>
    [JsonPropertyName("nextBillingDate")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? nextBillingDate { get; set; } = null;
}