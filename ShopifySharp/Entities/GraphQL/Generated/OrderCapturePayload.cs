#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `orderCapture` mutation.
/// </summary>
public record OrderCapturePayload : IGraphQLObject
{
    /// <summary>
    /// The created capture transaction.
    /// </summary>
    [JsonPropertyName("transaction")]
    public OrderTransaction? transaction { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}