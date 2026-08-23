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
/// The customer accounts-specific component customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurface : IGraphQLObject
{
    /// <summary>
    /// The customer accounts components.
    /// </summary>
    [JsonPropertyName("components")]
    public CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponents? components { get; set; } = null;
}