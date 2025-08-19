#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `fulfillmentConstraintRuleDelete` mutation.
/// </summary>
public record FulfillmentConstraintRuleDeletePayload : IGraphQLObject
{
    /// <summary>
    /// Whether or not the fulfillment constraint rule was successfully deleted.
    /// </summary>
    [JsonPropertyName("success")]
    public bool? success { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<FulfillmentConstraintRuleDeleteUserError>? userErrors { get; set; } = null;
}