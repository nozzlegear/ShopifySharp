#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `customerDelete` mutation.
/// </summary>
public record CustomerDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted customer.
    /// </summary>
    [JsonPropertyName("deletedCustomerId")]
    public string? deletedCustomerId { get; set; } = null;

    /// <summary>
    /// The shop of the deleted customer.
    /// </summary>
    [JsonPropertyName("shop")]
    public Shop? shop { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}