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
/// The input fields for specifying the subscription contract and selecting the associated billing cycle.
/// </summary>
public record SubscriptionBillingCycleInput : GraphQLInputObject<SubscriptionBillingCycleInput>
{
    /// <summary>
    /// The ID of the subscription contract associated with the billing cycle.
    /// </summary>
    [JsonPropertyName("contractId")]
    public string? contractId { get; set; } = null;

    /// <summary>
    /// Selects the billing cycle by date or index.
    /// </summary>
    [JsonPropertyName("selector")]
    public SubscriptionBillingCycleSelector? selector { get; set; } = null;
}