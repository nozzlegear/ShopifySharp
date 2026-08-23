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
/// Return type for `giftCardProductSet` mutation.
/// </summary>
public record GiftCardProductSetPayload : IGraphQLObject
{
    /// <summary>
    /// The gift card product object.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The product set operation, returned when run in asynchronous mode.
    /// </summary>
    [JsonPropertyName("productSetOperation")]
    public ProductSetOperation? productSetOperation { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<GiftCardProductSetUserError>? userErrors { get; set; } = null;
}