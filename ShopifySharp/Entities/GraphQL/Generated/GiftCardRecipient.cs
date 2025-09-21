#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a recipient who will receive the issued gift card.
/// </summary>
public record GiftCardRecipient : IGraphQLObject
{
    /// <summary>
    /// The message sent with the gift card.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;

    /// <summary>
    /// The preferred name of the recipient who will receive the gift card.
    /// </summary>
    [JsonPropertyName("preferredName")]
    public string? preferredName { get; set; } = null;

    /// <summary>
    /// The recipient who will receive the gift card.
    /// </summary>
    [JsonPropertyName("recipient")]
    public Customer? recipient { get; set; } = null;

    /// <summary>
    /// The scheduled datetime on which the gift card will be sent to the recipient.
    /// The gift card will be sent within an hour of the specified datetime.
    /// </summary>
    [JsonPropertyName("sendNotificationAt")]
    public DateTime? sendNotificationAt { get; set; } = null;
}