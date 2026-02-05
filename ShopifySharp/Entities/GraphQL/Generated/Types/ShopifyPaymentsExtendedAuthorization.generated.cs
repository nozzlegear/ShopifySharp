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
/// Presents all Shopify Payments information related to an extended authorization.
/// </summary>
public record ShopifyPaymentsExtendedAuthorization : IGraphQLObject
{
    /// <summary>
    /// The time after which the extended authorization expires. After the expiry, the merchant is unable to capture the payment.
    /// </summary>
    [JsonPropertyName("extendedAuthorizationExpiresAt")]
    public DateTimeOffset? extendedAuthorizationExpiresAt { get; set; } = null;

    /// <summary>
    /// The time after which capture will incur an additional fee.
    /// </summary>
    [JsonPropertyName("standardAuthorizationExpiresAt")]
    public DateTimeOffset? standardAuthorizationExpiresAt { get; set; } = null;
}