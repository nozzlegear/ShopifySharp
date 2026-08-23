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
/// The checkout-specific component customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCheckoutSurface : IGraphQLObject
{
    /// <summary>
    /// The checkout components.
    /// </summary>
    [JsonPropertyName("components")]
    public CheckoutAndAccountsConfigurationBrandingCheckoutComponents? components { get; set; } = null;
}