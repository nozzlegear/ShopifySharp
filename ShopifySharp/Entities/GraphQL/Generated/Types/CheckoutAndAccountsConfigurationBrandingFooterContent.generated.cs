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
/// The footer content customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingFooterContent : IGraphQLObject
{
    /// <summary>
    /// The visibility for footer content.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutAndAccountsConfigurationBrandingVisibility? visibility { get; set; } = null;
}