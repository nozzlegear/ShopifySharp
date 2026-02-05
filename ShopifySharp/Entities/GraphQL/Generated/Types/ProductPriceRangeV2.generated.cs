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
/// The price range of the product.
/// </summary>
public record ProductPriceRangeV2 : IGraphQLObject
{
    /// <summary>
    /// The highest variant's price.
    /// </summary>
    [JsonPropertyName("maxVariantPrice")]
    public MoneyV2? maxVariantPrice { get; set; } = null;

    /// <summary>
    /// The lowest variant's price.
    /// </summary>
    [JsonPropertyName("minVariantPrice")]
    public MoneyV2? minVariantPrice { get; set; } = null;
}