#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to add a recipient to a gift card.
/// </summary>
public record GiftCardRecipientInput : GraphQLInputObject<GiftCardRecipientInput>
{
    /// <summary>
    /// The ID of the customer who will be the recipient of the gift card. Requires `write_customers` access_scope.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The personalized message intended for the recipient.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;

    /// <summary>
    /// The preferred name of the recipient.
    /// </summary>
    [JsonPropertyName("preferredName")]
    public string? preferredName { get; set; } = null;

    /// <summary>
    /// The scheduled datetime on which the gift card will be sent to the recipient.
    /// The gift card will be sent within an hour of the specified datetime.
    /// </summary>
    [JsonPropertyName("sendNotificationAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? sendNotificationAt { get; set; } = null;
}