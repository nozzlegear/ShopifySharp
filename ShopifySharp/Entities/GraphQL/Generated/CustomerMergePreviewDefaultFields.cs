#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The fields that will be kept as part of a customer merge preview.
/// </summary>
public record CustomerMergePreviewDefaultFields : IGraphQLObject
{
    /// <summary>
    /// The merged addresses resulting from a customer merge.
    /// </summary>
    [JsonPropertyName("addresses")]
    public MailingAddressConnection? addresses { get; set; } = null;

    /// <summary>
    /// The default address resulting from a customer merge.
    /// </summary>
    [JsonPropertyName("defaultAddress")]
    public MailingAddress? defaultAddress { get; set; } = null;

    /// <summary>
    /// The total number of customer-specific discounts resulting from a customer merge.
    /// </summary>
    [JsonPropertyName("discountNodeCount")]
    public ulong? discountNodeCount { get; set; } = null;

    /// <summary>
    /// The merged customer-specific discounts resulting from a customer merge.
    /// </summary>
    [JsonPropertyName("discountNodes")]
    public DiscountNodeConnection? discountNodes { get; set; } = null;

    /// <summary>
    /// The full name of the customer, based on the values for `first_name` and
    /// `last_name`. If `first_name` and `last_name` aren't available, then this field
    /// falls back to the customer's email address. If the customer's email isn't
    /// available, then this field falls back to the customer's phone number.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// The total number of merged draft orders.
    /// </summary>
    [JsonPropertyName("draftOrderCount")]
    public ulong? draftOrderCount { get; set; } = null;

    /// <summary>
    /// The merged draft orders resulting from a customer merge.
    /// </summary>
    [JsonPropertyName("draftOrders")]
    public DraftOrderConnection? draftOrders { get; set; } = null;

    /// <summary>
    /// The email state of a customer.
    /// </summary>
    [JsonPropertyName("email")]
    public CustomerEmailAddress? email { get; set; } = null;

    /// <summary>
    /// The first name resulting from a customer merge.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// The total number of merged gift cards.
    /// </summary>
    [JsonPropertyName("giftCardCount")]
    public ulong? giftCardCount { get; set; } = null;

    /// <summary>
    /// The merged gift cards resulting from a customer merge.
    /// </summary>
    [JsonPropertyName("giftCards")]
    public GiftCardConnection? giftCards { get; set; } = null;

    /// <summary>
    /// The last name resulting from a customer merge.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// The total number of merged metafields.
    /// </summary>
    [JsonPropertyName("metafieldCount")]
    public ulong? metafieldCount { get; set; } = null;

    /// <summary>
    /// The merged note resulting from a customer merge.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The total number of merged orders.
    /// </summary>
    [JsonPropertyName("orderCount")]
    public ulong? orderCount { get; set; } = null;

    /// <summary>
    /// The merged orders resulting from a customer merge.
    /// </summary>
    [JsonPropertyName("orders")]
    public OrderConnection? orders { get; set; } = null;

    /// <summary>
    /// The phone number state of a customer.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public CustomerPhoneNumber? phoneNumber { get; set; } = null;

    /// <summary>
    /// The merged tags resulting from a customer merge.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;
}