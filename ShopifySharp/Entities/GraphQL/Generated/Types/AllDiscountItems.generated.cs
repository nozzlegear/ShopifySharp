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
/// Represents a discount configuration that applies to all items in a customer's
/// cart without restriction. This object enables store-wide promotions that affect
/// every product equally.
/// For example, a "Sitewide 10% Off Everything" sale would target all items,
/// ensuring that every product in the customer's cart receives the promotional
/// discount regardless of category or collection.
/// This universal targeting approach simplifies promotional campaigns and provides
/// customers with clear, straightforward savings across the entire product catalog.
/// </summary>
public record AllDiscountItems : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Whether all items are eligible for the discount. This value always returns `true`.
    /// </summary>
    [JsonPropertyName("allItems")]
    public bool? allItems { get; set; } = null;
}