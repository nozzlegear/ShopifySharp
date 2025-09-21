#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A risk fact belongs to a single risk assessment and serves to provide additional
/// context for an assessment. Risk facts are not necessarily tied to the result of
/// the recommendation.
/// </summary>
public record RiskFact : IGraphQLObject
{
    /// <summary>
    /// A description of the fact.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// Indicates whether the fact is a negative, neutral or positive contributor with regards to risk.
    /// </summary>
    [JsonPropertyName("sentiment")]
    public RiskFactSentiment? sentiment { get; set; } = null;
}