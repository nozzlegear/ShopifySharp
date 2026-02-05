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
/// Indicates that a discount applies to all buyers without restrictions, enabling
/// universal promotions that reach every customer. This selection removes
/// buyer-specific limitations from discount eligibility.
/// For example, a flash sale or grand opening promotion would target all buyers to maximize participation and store visibility.
/// Learn more about [discount targeting](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountApplication).
/// </summary>
public record DiscountBuyerSelectionAll : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// All buyers are eligible for the discount.
    /// </summary>
    [JsonPropertyName("all")]
    public DiscountBuyerSelection? all { get; set; } = null;
}