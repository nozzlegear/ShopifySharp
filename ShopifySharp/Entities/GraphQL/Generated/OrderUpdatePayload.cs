#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `orderUpdate` mutation.
/// </summary>
public record OrderUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated order.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}