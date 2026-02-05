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
/// Indicates that a shipping discount applies to all countries without restriction,
/// enabling merchants to create truly global promotions. This object represents
/// universal geographic eligibility for shipping discount offers.
/// For example, an online store launching a "Worldwide Free Shipping" campaign
/// would use this configuration to ensure customers from any country can benefit
/// from the promotion.
/// This setting simplifies international discount management by eliminating the
/// need to manually select individual countries or regions, making it ideal for
/// digital products or stores with comprehensive global shipping capabilities.
/// </summary>
public record DiscountCountryAll : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Whether the discount can be applied to all countries as shipping destination. This value is always `true`.
    /// </summary>
    [JsonPropertyName("allCountries")]
    public bool? allCountries { get; set; } = null;
}