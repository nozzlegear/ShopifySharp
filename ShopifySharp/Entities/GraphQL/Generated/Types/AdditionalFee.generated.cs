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
/// Additional fees applied to an
/// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order)
/// beyond the standard product and shipping costs. Additional fees typically
/// include duties, import fees, or other special handling charges that need
/// separate tracking from regular
/// [`LineItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/LineItem) objects.
/// Each fee includes its name, price in both shop and presentment currencies, and
/// any applicable taxes broken down by
/// [`TaxLine`](https://shopify.dev/docs/api/admin-graphql/latest/objects/TaxLine).
/// </summary>
public record AdditionalFee : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the additional fee.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The price of the additional fee.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyBag? price { get; set; } = null;

    /// <summary>
    /// A list of taxes charged on the additional fee.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<TaxLine>? taxLines { get; set; } = null;
}