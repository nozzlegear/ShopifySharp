#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `giftCardUpdate` mutation.
/// </summary>
public record GiftCardUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated gift card.
    /// </summary>
    [JsonPropertyName("giftCard")]
    public GiftCard? giftCard { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}