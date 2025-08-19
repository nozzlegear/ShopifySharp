#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Summary of risk characteristics for an order.
/// See the [example query "Retrieves a list of all order risks for an order"](https://shopify.dev/docs/api/admin-graphql/unstable/queries/order?example=Retrieves+a+list+of+all+order+risks+for+an+order).
/// </summary>
public record OrderRiskSummary : IGraphQLObject
{
    /// <summary>
    /// The list of risk assessments for the order.
    /// </summary>
    [JsonPropertyName("assessments")]
    public ICollection<OrderRiskAssessment>? assessments { get; set; } = null;

    /// <summary>
    /// The recommendation for the order based on the results of the risk assessments.
    /// This suggests the action the merchant should take with regards to its risk of fraud.
    /// </summary>
    [JsonPropertyName("recommendation")]
    public OrderRiskRecommendationResult? recommendation { get; set; } = null;
}