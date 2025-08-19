#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a fraud check on an order. This object is deprecated in favor of [OrderRiskAssessment](https://shopify.dev/api/admin-graphql/latest/objects/OrderRiskAssessment)
/// and its enhanced capabilities.
/// </summary>
public record OrderRisk : IGraphQLObject
{
    /// <summary>
    /// Whether the risk level is shown in the Shopify admin. If false, then this
    /// order risk is ignored when Shopify determines the overall risk level for the order.
    /// </summary>
    [JsonPropertyName("display")]
    [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
    public bool? display { get; set; } = null;

    /// <summary>
    /// The likelihood that an order is fraudulent, based on this order risk. The
    /// level can be set by Shopify risk analysis or by an app.
    /// </summary>
    [JsonPropertyName("level")]
    [Obsolete("This field is deprecated in favor of OrderRiskAssessment.riskLevel which allows for more granular risk levels, including PENDING and NONE.")]
    public OrderRiskLevel? level { get; set; } = null;

    /// <summary>
    /// The risk message that's shown to the merchant in the Shopify admin.
    /// </summary>
    [JsonPropertyName("message")]
    [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
    public string? message { get; set; } = null;
}