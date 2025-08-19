#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to create a fact on an order risk assessment.
/// </summary>
public record OrderRiskAssessmentFactInput : GraphQLInputObject<OrderRiskAssessmentFactInput>
{
    /// <summary>
    /// A description of the fact. Large values are truncated to 256 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// Indicates whether the fact is a negative, neutral or positive contributor with regards to risk.
    /// </summary>
    [JsonPropertyName("sentiment")]
    public RiskFactSentiment? sentiment { get; set; } = null;
}