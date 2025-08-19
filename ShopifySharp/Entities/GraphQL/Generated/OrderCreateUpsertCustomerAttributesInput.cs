#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for creating a new customer object or identifying an existing
/// customer to update & associate with the order.
/// </summary>
public record OrderCreateUpsertCustomerAttributesInput : GraphQLInputObject<OrderCreateUpsertCustomerAttributesInput>
{
    /// <summary>
    /// A list of addresses to associate with the customer.
    /// </summary>
    [JsonPropertyName("addresses")]
    public ICollection<OrderCreateCustomerAddressInput>? addresses { get; set; } = null;

    /// <summary>
    /// The email address to update the customer with. If no `id` is provided, this is used to uniquely identify
    ///                  the customer.
    ///                 > Note:
    ///                 > If both this email input field and the email on `OrderCreateOrderInput` are provided, this field will
    ///                 > take precedence.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// The first name of the customer.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// The id of the customer to associate to the order.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The last name of the customer.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// A unique identifier for the customer that's used with [Multipass login](https://shopify.dev/api/multipass).
    /// </summary>
    [JsonPropertyName("multipassIdentifier")]
    public string? multipassIdentifier { get; set; } = null;

    /// <summary>
    /// A note about the customer.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The unique phone number ([E.164 format](https://en.wikipedia.org/wiki/E.164)) for this customer.
    ///                  Attempting to assign the same phone number to multiple customers returns an error. The property can be
    ///                  set using different formats, but each format must represent a number that can be dialed from anywhere
    ///                  in the world. The following formats are all valid:
    ///                   - 6135551212
    ///                   - +16135551212
    ///                   - (613)555-1212
    ///                   - +1 613-555-1212
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// Tags that the shop owner has attached to the customer. A customer can have up
    /// to 250 tags. Each tag can have up to 255 characters.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;

    /// <summary>
    /// Whether the customer is exempt from paying taxes on their order. If `true`,
    /// then taxes won't be applied to an order at checkout. If `false`, then taxes
    /// will be applied at checkout.
    /// </summary>
    [JsonPropertyName("taxExempt")]
    public bool? taxExempt { get; set; } = null;
}