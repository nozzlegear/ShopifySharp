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
/// The input fields for creating or updating a web pixel.
/// </summary>
public record WebPixelInput : GraphQLInputObject<WebPixelInput>
{
    /// <summary>
    /// The
    /// [settings object](https://shopify.dev/docs/apps/build/marketing-analytics/build-web-pixels#step-2-define-your-web-pixel-settings)
    /// for the web pixel. This object specifies configuration options that control the web pixel's functionality and behavior.
    /// You can find the settings for a web pixel in `extensions/<your_extension_name>/shopify.extension.toml`.
    /// </summary>
    [JsonPropertyName("settings")]
    public string? settings { get; set; } = null;
}