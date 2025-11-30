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
/// The input fields used to update the text fields customizations.
/// </summary>
public record CheckoutBrandingTextFieldInput : GraphQLInputObject<CheckoutBrandingTextFieldInput>
{
    /// <summary>
    /// The border used for text fields.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutBrandingBorder? border { get; set; } = null;

    /// <summary>
    /// The typography customizations used for text fields.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutBrandingTypographyStyleInput? typography { get; set; } = null;
}