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
/// Return type for `giftCardCreate` mutation.
/// </summary>
public record GiftCardCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created gift card.
    /// </summary>
    [JsonPropertyName("giftCard")]
    public GiftCard? giftCard { get; set; } = null;

    /// <summary>
    /// The created gift card's code.
    /// </summary>
    [JsonPropertyName("giftCardCode")]
    public string? giftCardCode { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<GiftCardUserError>? userErrors { get; set; } = null;
}