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
/// Return type for `fulfillmentConstraintRuleCreate` mutation.
/// </summary>
public record FulfillmentConstraintRuleCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The newly created fulfillment constraint rule.
    /// </summary>
    [JsonPropertyName("fulfillmentConstraintRule")]
    public FulfillmentConstraintRule? fulfillmentConstraintRule { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<FulfillmentConstraintRuleCreateUserError>? userErrors { get; set; } = null;
}