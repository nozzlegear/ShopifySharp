#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The risk assessments for an order.
/// See the [example query "Retrieves a list of all order risks for an order"](https://shopify.dev/docs/api/admin-graphql/unstable/queries/order?example=Retrieves+a+list+of+all+order+risks+for+an+order).
/// </summary>
public record OrderRiskAssessment : IGraphQLObject
{
    /// <summary>
    /// Optional facts used to describe the risk assessment. The values in here are specific to the provider.
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
    /// The likelihood that the order is fraudulent, based on this risk assessment.
    /// </summary>
    [JsonPropertyName("riskLevel")]
    public RiskAssessmentResult? riskLevel { get; set; } = null;
}