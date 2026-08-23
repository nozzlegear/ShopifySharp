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
/// Summary of risk characteristics for an order.
/// See the [example query "Retrieve order risk assessments"](https://shopify.dev/docs/api/admin-graphql/unstable/queries/order?example=retrieve-order-risk-assessments).
/// </summary>
public record OrderRiskSummary : IGraphQLObject
{
    /// <summary>
    /// The risk assessments for the order.
    /// </summary>
    [JsonPropertyName("assessments")]
    public ICollection<OrderRiskAssessment>? assessments { get; set; } = null;

    /// <summary>
    /// The recommended action for the order based on its risk assessments.
    /// </summary>
    [JsonPropertyName("recommendation")]
    public OrderRiskRecommendationResult? recommendation { get; set; } = null;
}