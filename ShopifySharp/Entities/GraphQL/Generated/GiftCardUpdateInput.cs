#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to update a gift card.
/// </summary>
public record GiftCardUpdateInput : GraphQLInputObject<GiftCardUpdateInput>
{
    /// <summary>
    /// The ID of the customer who will receive the gift card. The ID can't be changed
    /// if the gift card already has an assigned customer ID.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? customerId { get; set; } = null;

    /// <summary>
    /// The date at which the gift card will expire. If set to `null`, then the gift card will never expire.
    /// </summary>
    [JsonPropertyName("expiresOn")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateOnly? expiresOn { get; set; } = null;

    /// <summary>
    /// The note associated with the gift card, which isn't visible to the customer.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The recipient attributes of the gift card.
    /// </summary>
    [JsonPropertyName("recipientAttributes")]
    public GiftCardRecipientInput? recipientAttributes { get; set; } = null;

    /// <summary>
    /// The suffix of the Liquid template that's used to render the gift card online.
    /// For example, if the value is `birthday`, then the gift card is rendered using the template `gift_card.birthday.liquid`.
    /// </summary>
    [JsonPropertyName("templateSuffix")]
    public string? templateSuffix { get; set; } = null;
}