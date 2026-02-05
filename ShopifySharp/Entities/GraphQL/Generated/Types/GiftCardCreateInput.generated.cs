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
/// The input fields to issue a gift card.
/// </summary>
public record GiftCardCreateInput : GraphQLInputObject<GiftCardCreateInput>
{
    /// <summary>
    /// The gift card's code. It must be 8-20 characters long and contain only letters(a-z) and numbers(0-9).
    /// It isn't case sensitive. If not provided, then a random code will be generated.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The ID of the customer who will receive the gift card. Requires `write_customers` access_scope.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? customerId { get; set; } = null;

    /// <summary>
    /// The date at which the gift card will expire. If not provided, then the gift card will never expire.
    /// </summary>
    [JsonPropertyName("expiresOn")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateOnly? expiresOn { get; set; } = null;

    /// <summary>
    /// The initial value of the gift card.
    /// </summary>
    [JsonPropertyName("initialValue")]
    public decimal? initialValue { get; set; } = null;

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
    /// If not provided, then the default `gift_card.liquid` template is used.
    /// </summary>
    [JsonPropertyName("templateSuffix")]
    public string? templateSuffix { get; set; } = null;
}