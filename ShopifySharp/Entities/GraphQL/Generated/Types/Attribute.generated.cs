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
/// A custom property. Attributes are used to store additional information about a Shopify resource, such as
/// products, customers, or orders. Attributes are stored as key-value pairs.
/// For example, a list of attributes might include whether a customer is a first-time buyer (`"customer_first_order": "true"`),
/// whether an order is gift-wrapped (`"gift_wrapped": "true"`), a preferred delivery date
/// (`"preferred_delivery_date": "2025-10-01"`), the discount applied (`"loyalty_discount_applied": "10%"`), and any
/// notes provided by the customer (`"customer_notes": "Please leave at the front door"`).
/// </summary>
public record Attribute : IGraphQLObject
{
    /// <summary>
    /// The key or name of the attribute. For example, `"customer_first_order"`.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The value of the attribute. For example, `"true"`.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}