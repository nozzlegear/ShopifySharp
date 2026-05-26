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
/// Represents the default expiration configuration of gift cards on the shop.
/// </summary>
public record GiftCardExpirationConfiguration : IGraphQLObject
{
    /// <summary>
    /// The unit for the default gift card expiration.
    /// </summary>
    [JsonPropertyName("expirationUnit")]
    public GiftCardConfigurationExpirationUnit? expirationUnit { get; set; } = null;

    /// <summary>
    /// The value for the default gift card expiration.
    /// </summary>
    [JsonPropertyName("expirationValue")]
    public int? expirationValue { get; set; } = null;
}