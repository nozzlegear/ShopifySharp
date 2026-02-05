#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `menuCreate` mutation.
/// </summary>
public record MenuCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created menu.
    /// </summary>
    [JsonPropertyName("menu")]
    public Menu? menu { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MenuCreateUserError>? userErrors { get; set; } = null;
}