#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `scriptTagDelete` mutation.
/// </summary>
public record ScriptTagDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted script tag.
    /// </summary>
    [JsonPropertyName("deletedScriptTagId")]
    public string? deletedScriptTagId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}