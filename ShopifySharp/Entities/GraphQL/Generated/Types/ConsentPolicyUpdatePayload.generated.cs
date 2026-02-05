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
/// Return type for `consentPolicyUpdate` mutation.
/// </summary>
public record ConsentPolicyUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// All updated and created consent policies. The consent policies that haven't
    /// been modified as part of the mutation aren't returned.
    /// </summary>
    [JsonPropertyName("updatedPolicies")]
    public ICollection<ConsentPolicy>? updatedPolicies { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ConsentPolicyError>? userErrors { get; set; } = null;
}