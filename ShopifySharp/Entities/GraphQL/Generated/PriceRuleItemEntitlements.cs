#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The items to which this price rule applies. This may be multiple products,
/// product variants, collections or combinations of the aforementioned.
/// </summary>
public record PriceRuleItemEntitlements : IGraphQLObject
{
    /// <summary>
    /// The collections to which the price rule applies.
    /// </summary>
    [JsonPropertyName("collections")]
    public CollectionConnection? collections { get; set; } = null;

    /// <summary>
    /// The products to which the price rule applies.
    /// </summary>
    [JsonPropertyName("products")]
    public ProductConnection? products { get; set; } = null;

    /// <summary>
    /// The product variants to which the price rule applies.
    /// </summary>
    [JsonPropertyName("productVariants")]
    public ProductVariantConnection? productVariants { get; set; } = null;

    /// <summary>
    /// Whether the price rule applies to all line items.
    /// </summary>
    [JsonPropertyName("targetAllLineItems")]
    public bool? targetAllLineItems { get; set; } = null;
}