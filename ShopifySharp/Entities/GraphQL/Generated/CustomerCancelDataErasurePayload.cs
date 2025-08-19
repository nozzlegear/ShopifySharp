#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `customerCancelDataErasure` mutation.
/// </summary>
public record CustomerCancelDataErasurePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the customer whose pending data erasure has been cancelled.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? customerId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CustomerCancelDataErasureUserError>? userErrors { get; set; } = null;
}