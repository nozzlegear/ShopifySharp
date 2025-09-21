#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A new [shipping line](https://shopify.dev/api/admin-graphql/latest/objects/shippingline)
/// added as part of an order edit.
/// </summary>
public record OrderStagedChangeAddShippingLine : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The phone number at the shipping address.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The shipping line's title that's shown to the buyer.
    /// </summary>
    [JsonPropertyName("presentmentTitle")]
    public string? presentmentTitle { get; set; } = null;

    /// <summary>
    /// The price that applies to the shipping line.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;

    /// <summary>
    /// The title of the shipping line.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}