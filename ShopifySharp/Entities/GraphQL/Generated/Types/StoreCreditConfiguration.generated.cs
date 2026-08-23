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
/// The store credit configuration for a shop.
/// </summary>
public record StoreCreditConfiguration : IGraphQLObject
{
    /// <summary>
    /// Whether store credit is enabled for customers on checkout.
    /// </summary>
    [JsonPropertyName("storeCreditEnabled")]
    public bool? storeCreditEnabled { get; set; } = null;
}