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
/// Creates percentage-based discounts that reduce item prices by a specified
/// percentage amount. This gives merchants a flexible way to offer proportional
/// savings that automatically scale with order value.
/// For example, a "20% off all winter clothing" promotion would use this object to
/// apply consistent percentage savings across different price points.
/// Learn more about [discount types](https://help.shopify.com/manual/discounts/).
/// </summary>
public record DiscountPercentage : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The percentage value of the discount.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}