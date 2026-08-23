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
/// The content customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingContent : IGraphQLObject
{
    /// <summary>
    /// The divider style and visibility.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutAndAccountsConfigurationBrandingContainerDivider? divider { get; set; } = null;
}