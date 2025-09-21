#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the subscription lines the discount applies on.
/// </summary>
public record SubscriptionManualDiscountEntitledLinesInput : GraphQLInputObject<SubscriptionManualDiscountEntitledLinesInput>
{
    /// <summary>
    /// Specify whether the subscription discount will apply on all subscription lines.
    /// </summary>
    [JsonPropertyName("all")]
    public bool? all { get; set; } = null;

    /// <summary>
    /// The ID of the lines to add to or remove from the subscription discount.
    /// </summary>
    [JsonPropertyName("lines")]
    public SubscriptionManualDiscountLinesInput? lines { get; set; } = null;
}