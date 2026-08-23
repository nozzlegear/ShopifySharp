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
/// The input fields for creating an order risk assessment.
/// </summary>
public record OrderRiskAssessmentCreateInput : GraphQLInputObject<OrderRiskAssessmentCreateInput>
{
    /// <summary>
    /// Facts to include with the risk assessment. Up to 20 facts can be provided.
    /// </summary>
    [JsonPropertyName("facts")]
    public ICollection<OrderRiskAssessmentFactInput>? facts { get; set; } = null;

    /// <summary>
    /// The ID of the order to assess.
    /// </summary>
    [JsonPropertyName("orderId")]
    public string? orderId { get; set; } = null;

    /// <summary>
    /// The risk level assigned to the order.
    /// </summary>
    [JsonPropertyName("riskLevel")]
    public RiskAssessmentResult? riskLevel { get; set; } = null;
}