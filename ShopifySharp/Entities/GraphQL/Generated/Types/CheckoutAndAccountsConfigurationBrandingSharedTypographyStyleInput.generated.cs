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
/// The input fields for customizing the shared typography.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingSharedTypographyStyleInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingSharedTypographyStyleInput>
{
    /// <summary>
    /// The kerning.
    /// </summary>
    [JsonPropertyName("kerning")]
    public CheckoutAndAccountsConfigurationBrandingTypographyKerning? kerning { get; set; } = null;

    /// <summary>
    /// The letter case.
    /// </summary>
    [JsonPropertyName("letterCase")]
    public CheckoutAndAccountsConfigurationBrandingTypographyLetterCase? letterCase { get; set; } = null;
}