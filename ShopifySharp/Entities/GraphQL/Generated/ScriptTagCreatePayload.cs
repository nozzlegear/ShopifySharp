#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `scriptTagCreate` mutation.
/// </summary>
public record ScriptTagCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The script tag that was created.
    /// </summary>
    [JsonPropertyName("scriptTag")]
    public ScriptTag? scriptTag { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}