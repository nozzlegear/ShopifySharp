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
/// The form controls customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingControl : IGraphQLObject
{
    /// <summary>
    /// The border.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutAndAccountsConfigurationBrandingSimpleBorder? border { get; set; } = null;

    /// <summary>
    /// The corner radius.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutAndAccountsConfigurationBrandingCornerRadius? cornerRadius { get; set; } = null;

    /// <summary>
    /// The label position.
    /// </summary>
    [JsonPropertyName("labelPosition")]
    public CheckoutAndAccountsConfigurationBrandingLabelPosition? labelPosition { get; set; } = null;
}