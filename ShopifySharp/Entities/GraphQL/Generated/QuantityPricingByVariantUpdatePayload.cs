#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `quantityPricingByVariantUpdate` mutation.
/// </summary>
public record QuantityPricingByVariantUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The variants for which quantity pricing was created successfully in the price list.
    /// </summary>
    [JsonPropertyName("productVariants")]
    public ICollection<ProductVariant>? productVariants { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<QuantityPricingByVariantUserError>? userErrors { get; set; } = null;
}