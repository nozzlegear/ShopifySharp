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
/// A list of products and product variants that the discount can have as a
/// prerequisite or a list of products and product variants to which the discount
/// can be applied.
/// </summary>
public record DiscountProducts : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The list of products that the discount can have as a prerequisite or the list
    /// of products to which the discount can be applied.
    /// </summary>
    [JsonPropertyName("products")]
    public ProductConnection? products { get; set; } = null;

    /// <summary>
    /// The list of product variants that the discount can have as a prerequisite or
    /// the list of product variants to which the discount can be applied.
    /// </summary>
    [JsonPropertyName("productVariants")]
    public ProductVariantConnection? productVariants { get; set; } = null;
}