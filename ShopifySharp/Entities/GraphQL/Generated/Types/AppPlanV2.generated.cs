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
/// Contains the pricing details for the app plan that a merchant has subscribed to within their current billing arrangement.
/// This simplified object focuses on the essential pricing information merchants
/// need to understand their current subscription costs and billing structure.
/// Details about subscription management and pricing strategies are available in
/// the [app billing documentation](https://shopify.dev/docs/apps/launch/billing).
/// </summary>
public record AppPlanV2 : IGraphQLObject
{
    /// <summary>
    /// The plan billed to a shop on a recurring basis.
    /// </summary>
    [JsonPropertyName("pricingDetails")]
    public AppPricingDetails? pricingDetails { get; set; } = null;
}