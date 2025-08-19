#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `giftCardSendNotificationToRecipient` mutation.
/// </summary>
public record GiftCardSendNotificationToRecipientPayload : IGraphQLObject
{
    /// <summary>
    /// The gift card that was sent.
    /// </summary>
    [JsonPropertyName("giftCard")]
    public GiftCard? giftCard { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<GiftCardSendNotificationToRecipientUserError>? userErrors { get; set; } = null;
}