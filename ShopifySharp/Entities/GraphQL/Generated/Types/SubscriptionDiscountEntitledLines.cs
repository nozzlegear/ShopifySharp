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
/// Represents the subscription lines the discount applies on.
/// </summary>
public record SubscriptionDiscountEntitledLines : IGraphQLObject
{
    /// <summary>
    /// Specify whether the subscription discount will apply on all subscription lines.
    /// </summary>
    [JsonPropertyName("all")]
    public bool? all { get; set; } = null;

    /// <summary>
    /// The list of subscription lines associated with the subscription discount.
    /// </summary>
    [JsonPropertyName("lines")]
    public SubscriptionLineConnection? lines { get; set; } = null;
}