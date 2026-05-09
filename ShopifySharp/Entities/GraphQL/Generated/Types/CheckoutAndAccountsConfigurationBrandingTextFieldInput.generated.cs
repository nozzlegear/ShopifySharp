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
/// The input fields for customizing the text fields.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingTextFieldInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingTextFieldInput>
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
    public CheckoutAndAccountsConfigurationBrandingTypographyStyleInput? typography { get; set; } = null;
}