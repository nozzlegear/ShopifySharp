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
/// The input fields used to update the font size.
/// </summary>
public record CheckoutBrandingFontSizeInput : GraphQLInputObject<CheckoutBrandingFontSizeInput>
{
    /// <summary>
    /// The base font size. Its value should be between 12.0 and 18.0.
    /// </summary>
    [JsonPropertyName("base")]
    public decimal? @base { get; set; } = null;

    /// <summary>
    /// The scale ratio used to derive all font sizes such as small and large. Its value should be between 1.0 and 1.4.
    /// </summary>
    [JsonPropertyName("ratio")]
    public decimal? ratio { get; set; } = null;
}