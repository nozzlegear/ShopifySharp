#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `scriptTagUpdate` mutation.
/// </summary>
public record ScriptTagUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The script tag that was updated.
    /// </summary>
    [JsonPropertyName("scriptTag")]
    public ScriptTag? scriptTag { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}