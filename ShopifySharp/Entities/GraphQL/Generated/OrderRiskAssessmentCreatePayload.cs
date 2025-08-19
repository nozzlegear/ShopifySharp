#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `orderRiskAssessmentCreate` mutation.
/// </summary>
public record OrderRiskAssessmentCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The order risk assessment created.
    /// </summary>
    [JsonPropertyName("orderRiskAssessment")]
    public OrderRiskAssessment? orderRiskAssessment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OrderRiskAssessmentCreateUserError>? userErrors { get; set; } = null;
}