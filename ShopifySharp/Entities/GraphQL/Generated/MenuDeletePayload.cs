#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `menuDelete` mutation.
/// </summary>
public record MenuDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted menu.
    /// </summary>
    [JsonPropertyName("deletedMenuId")]
    public string? deletedMenuId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MenuDeleteUserError>? userErrors { get; set; } = null;
}