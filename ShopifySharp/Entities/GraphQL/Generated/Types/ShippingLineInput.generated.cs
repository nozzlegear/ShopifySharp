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
/// The input fields for specifying the shipping details for the draft order.
/// > Note:
/// > A custom shipping line includes a title and price with `shippingRateHandle`
/// set to `nil`. A shipping line with a carrier-provided shipping rate (currently
/// set via the Shopify admin) includes the shipping rate handle.
/// </summary>
public record ShippingLineInput : GraphQLInputObject<ShippingLineInput>
{
    /// <summary>
    /// Price of the shipping rate with currency. If provided, `price` will be ignored.
    /// </summary>
    [JsonPropertyName("priceWithCurrency")]
    public MoneyInput? priceWithCurrency { get; set; } = null;

    /// <summary>
    /// A unique identifier for the shipping rate.
    /// </summary>
    [JsonPropertyName("shippingRateHandle")]
    public string? shippingRateHandle { get; set; } = null;

    /// <summary>
    /// Title of the shipping rate.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}