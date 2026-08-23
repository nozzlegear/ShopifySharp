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
/// The input fields for customizing the form controls.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingControlInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingControlInput>
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