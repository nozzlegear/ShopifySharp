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
/// The shop's entitlements.
/// </summary>
public record EntitlementsType : IGraphQLObject
{
    /// <summary>
    /// The shop's B2B entitlements.
    /// </summary>
    [JsonPropertyName("b2b")]
    public B2BType? b2b { get; set; } = null;

    /// <summary>
    /// Represents the markets for the shop.
    /// </summary>
    [JsonPropertyName("markets")]
    public MarketsType? markets { get; set; } = null;
}