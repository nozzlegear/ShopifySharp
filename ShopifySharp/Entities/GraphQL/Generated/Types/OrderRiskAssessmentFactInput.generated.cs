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
/// The input fields for a risk assessment fact.
/// </summary>
public record OrderRiskAssessmentFactInput : GraphQLInputObject<OrderRiskAssessmentFactInput>
{
    /// <summary>
    /// Descriptions longer than 256 characters are truncated.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// Indicates whether the fact contributes negatively, neutrally, or positively to risk.
    /// </summary>
    [JsonPropertyName("sentiment")]
    public RiskFactSentiment? sentiment { get; set; } = null;
}