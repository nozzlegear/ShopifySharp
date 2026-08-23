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
/// Return type for `cashDrawerCreate` mutation.
/// </summary>
public record CashDrawerCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created cash drawer.
    /// </summary>
    [JsonPropertyName("cashDrawer")]
    public CashDrawer? cashDrawer { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CashDrawerCreateUserError>? userErrors { get; set; } = null;
}