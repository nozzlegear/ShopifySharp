#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `customerRequestDataErasure` mutation.
/// </summary>
public record CustomerRequestDataErasurePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the customer that will be erased.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? customerId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CustomerRequestDataErasureUserError>? userErrors { get; set; } = null;
}