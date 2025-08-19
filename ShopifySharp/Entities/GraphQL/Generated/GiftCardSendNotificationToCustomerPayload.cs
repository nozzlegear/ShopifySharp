#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `giftCardSendNotificationToCustomer` mutation.
/// </summary>
public record GiftCardSendNotificationToCustomerPayload : IGraphQLObject
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
    public ICollection<GiftCardSendNotificationToCustomerUserError>? userErrors { get; set; } = null;
}