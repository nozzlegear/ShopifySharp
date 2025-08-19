#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `customerReplaceTaxExemptions` mutation.
/// </summary>
public record CustomerReplaceTaxExemptionsPayload : IGraphQLObject
{
    /// <summary>
    /// The updated customer.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}