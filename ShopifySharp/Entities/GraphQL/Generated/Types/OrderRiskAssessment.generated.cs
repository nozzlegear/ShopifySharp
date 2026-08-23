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
/// A risk assessment for an order.
/// See the [example query "Retrieve order risk assessments"](https://shopify.dev/docs/api/admin-graphql/unstable/queries/order?example=retrieve-order-risk-assessments).
/// </summary>
public record OrderRiskAssessment : IGraphQLObject
{
    /// <summary>
    /// Facts included with the risk assessment. Fact values are specific to the provider.
    /// See the [examples for the mutation orderRiskAssessmentCreate](https://shopify.dev/api/admin-graphql/unstable/mutations/orderRiskAssessmentCreate#section-examples).
    /// </summary>
    [JsonPropertyName("facts")]
    public ICollection<RiskFact>? facts { get; set; } = null;

    /// <summary>
    /// The app that provided the assessment, `null` if the assessment was provided by Shopify.
    /// </summary>
    [JsonPropertyName("provider")]
    public App? provider { get; set; } = null;

    /// <summary>
    /// The risk level assigned to the order.
    /// </summary>
    [JsonPropertyName("riskLevel")]
    public RiskAssessmentResult? riskLevel { get; set; } = null;
}