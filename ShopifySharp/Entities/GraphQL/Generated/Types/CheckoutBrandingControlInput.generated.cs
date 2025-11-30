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
/// The input fields used to update the form controls customizations.
/// </summary>
public record CheckoutBrandingControlInput : GraphQLInputObject<CheckoutBrandingControlInput>
{
    /// <summary>
    /// The border used for form controls.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutBrandingSimpleBorder? border { get; set; } = null;

    /// <summary>
    /// Set to TRANSPARENT to define transparent form controls. If null, form controls
    /// inherit colors from their scheme settings (for example, the main section
    /// inherits from `design_system.colors.schemes.scheme1.control` by default). Note
    /// that usage of the `customizations.control.color` setting to customize the form
    /// control color is deprecated.
    /// </summary>
    [JsonPropertyName("color")]
    public CheckoutBrandingColorSelection? color { get; set; } = null;

    /// <summary>
    /// The corner radius used for form controls.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingCornerRadius? cornerRadius { get; set; } = null;

    /// <summary>
    /// The label position used for form controls.
    /// </summary>
    [JsonPropertyName("labelPosition")]
    public CheckoutBrandingLabelPosition? labelPosition { get; set; } = null;
}