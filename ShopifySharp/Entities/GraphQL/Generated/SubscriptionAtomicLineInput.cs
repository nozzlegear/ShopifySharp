#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for mapping a subscription line to a discount.
/// </summary>
public record SubscriptionAtomicLineInput : GraphQLInputObject<SubscriptionAtomicLineInput>
{
    /// <summary>
    /// The discount to be added to the subscription line.
    /// </summary>
    [JsonPropertyName("discounts")]
    public ICollection<SubscriptionAtomicManualDiscountInput>? discounts { get; set; } = null;

    /// <summary>
    /// The new subscription line.
    /// </summary>
    [JsonPropertyName("line")]
    public SubscriptionLineInput? line { get; set; } = null;
}