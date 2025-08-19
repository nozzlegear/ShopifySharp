#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `giftCardDeactivate` mutation.
/// </summary>
public record GiftCardDeactivatePayload : IGraphQLObject
{
    /// <summary>
    /// The deactivated gift card.
    /// </summary>
    [JsonPropertyName("giftCard")]
    public GiftCard? giftCard { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<GiftCardDeactivateUserError>? userErrors { get; set; } = null;
}