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
/// The text fields customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingTextField : IGraphQLObject
{
    /// <summary>
    /// The border.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutAndAccountsConfigurationBrandingBorder? border { get; set; } = null;

    /// <summary>
    /// The typography.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutAndAccountsConfigurationBrandingTypographyStyle? typography { get; set; } = null;
}