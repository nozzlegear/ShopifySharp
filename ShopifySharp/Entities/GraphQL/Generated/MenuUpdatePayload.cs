#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `menuUpdate` mutation.
/// </summary>
public record MenuUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated menu.
    /// </summary>
    [JsonPropertyName("menu")]
    public Menu? menu { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MenuUpdateUserError>? userErrors { get; set; } = null;
}