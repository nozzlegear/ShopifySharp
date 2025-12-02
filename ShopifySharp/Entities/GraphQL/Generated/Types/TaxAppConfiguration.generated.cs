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
/// Tax app configuration of a merchant.
/// </summary>
public record TaxAppConfiguration : IGraphQLObject
{
    /// <summary>
    /// State of the tax app configuration.
    /// </summary>
    [JsonPropertyName("state")]
    public TaxPartnerState? state { get; set; } = null;
}