#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for specifying the information to be updated on an order when using the orderUpdate mutation.
/// </summary>
public record OrderInput : GraphQLInputObject<OrderInput>
{
    /// <summary>
    /// A new list of custom attributes for the order. Overwrites the existing custom attributes.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<AttributeInput>? customAttributes { get; set; } = null;

    /// <summary>
    /// A new customer email address for the order. Overwrites the existing email address.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// The ID of the order to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// A list of new [localized
    /// fields](https://shopify.dev/api/admin-graphql/latest/objects/localizedfield)
    /// to add to the existing list of localized fields for the order.
    /// </summary>
    [JsonPropertyName("localizedFields")]
    public ICollection<LocalizedFieldInput>? localizedFields { get; set; } = null;

    /// <summary>
    /// A list of new metafields to add to the existing metafields for the order.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The new contents for the note associated with the order. Overwrites the existing note.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The new purchase order number for the order.
    /// </summary>
    [JsonPropertyName("poNumber")]
    public string? poNumber { get; set; } = null;

    /// <summary>
    /// The new shipping address for the order. Overwrites the existing shipping address.
    /// </summary>
    [JsonPropertyName("shippingAddress")]
    public MailingAddressInput? shippingAddress { get; set; } = null;

    /// <summary>
    /// A new list of tags for the order. Overwrites the existing tags.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;
}