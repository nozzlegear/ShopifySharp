#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for an order risk assessment.
/// </summary>
public record OrderRiskAssessmentCreateInput : GraphQLInputObject<OrderRiskAssessmentCreateInput>
{
    /// <summary>
    /// The list of facts used to determine the fraud assessment.
    /// </summary>
    [JsonPropertyName("facts")]
    public ICollection<OrderRiskAssessmentFactInput>? facts { get; set; } = null;

    /// <summary>
    /// The ID of the order receiving the fraud assessment.
    /// </summary>
    [JsonPropertyName("orderId")]
    public string? orderId { get; set; } = null;

    /// <summary>
    /// The risk level of the fraud assessment.
    /// </summary>
    [JsonPropertyName("riskLevel")]
    public RiskAssessmentResult? riskLevel { get; set; } = null;
}