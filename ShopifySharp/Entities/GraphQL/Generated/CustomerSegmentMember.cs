#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The member of a segment.
/// </summary>
public record CustomerSegmentMember : IGraphQLObject, IHasMetafields
{
    /// <summary>
    /// The total amount of money that the member has spent on orders.
    /// </summary>
    [JsonPropertyName("amountSpent")]
    public MoneyV2? amountSpent { get; set; } = null;

    /// <summary>
    /// The member's default address.
    /// </summary>
    [JsonPropertyName("defaultAddress")]
    public MailingAddress? defaultAddress { get; set; } = null;

    /// <summary>
    /// The member's default email address.
    /// </summary>
    [JsonPropertyName("defaultEmailAddress")]
    public CustomerEmailAddress? defaultEmailAddress { get; set; } = null;

    /// <summary>
    /// The member's default phone number.
    /// </summary>
    [JsonPropertyName("defaultPhoneNumber")]
    public CustomerPhoneNumber? defaultPhoneNumber { get; set; } = null;

    /// <summary>
    /// The full name of the member, which is based on the values of the `first_name`
    /// and `last_name` fields. If the member's first name and last name aren't
    /// available, then the customer's email address is used. If the customer's email
    /// address isn't available, then the customer's phone number is used.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// The member's first name.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// The member’s ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The member's last name.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// The ID of the member's most recent order.
    /// </summary>
    [JsonPropertyName("lastOrderId")]
    public string? lastOrderId { get; set; } = null;

    /// <summary>
    /// Whether the customer can be merged with another customer.
    /// </summary>
    [JsonPropertyName("mergeable")]
    public CustomerMergeable? mergeable { get; set; } = null;

    /// <summary>
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    public Metafield? metafield { get; set; } = null;

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// A note about the member.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The total number of orders that the member has made.
    /// </summary>
    [JsonPropertyName("numberOfOrders")]
    public ulong? numberOfOrders { get; set; } = null;
}