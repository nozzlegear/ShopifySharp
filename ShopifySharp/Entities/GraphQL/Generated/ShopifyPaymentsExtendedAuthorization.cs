#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Presents all Shopify Payments information related to an extended authorization.
/// </summary>
public record ShopifyPaymentsExtendedAuthorization : IGraphQLObject
{
    /// <summary>
    /// The time after which the extended authorization expires. After the expiry, the merchant is unable to capture the payment.
    /// </summary>
    [JsonPropertyName("extendedAuthorizationExpiresAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? extendedAuthorizationExpiresAt { get; set; } = null;

    /// <summary>
    /// The time after which capture will incur an additional fee.
    /// </summary>
    [JsonPropertyName("standardAuthorizationExpiresAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? standardAuthorizationExpiresAt { get; set; } = null;
}