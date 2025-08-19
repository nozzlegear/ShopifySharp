#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The `WebPixel` object enables you to manage JavaScript code snippets
/// that run on an online store and collect
/// [behavioral data](https://shopify.dev/docs/api/web-pixels-api/standard-events)
/// for marketing campaign optimization and analytics.
/// Learn how to create a
/// [web pixel extension](https://shopify.dev/docs/apps/build/marketing-analytics/build-web-pixels)
/// to subscribe your app to events that are emitted by Shopify.
/// </summary>
public record WebPixel : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The
    /// [settings object](https://shopify.dev/docs/apps/build/marketing-analytics/build-web-pixels#step-2-define-your-web-pixel-settings)
    /// for the web pixel. This object specifies configuration options that control
    /// the web pixel's functionality and behavior. You can find the settings for a web pixel in
    /// `extensions/<your_extension_name>/shopify.extension.toml`.
    /// </summary>
    [JsonPropertyName("settings")]
    public string? settings { get; set; } = null;
}