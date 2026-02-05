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
/// <div class="note"><h4>Theme app extensions</h4>
///   <p>If your app integrates with a Shopify theme and you plan to submit it to the
/// Shopify App Store, you must use theme app extensions instead of Script tags.
/// Script tags can only be used with vintage themes. <a 
///href="/apps/online-store#what-integration-method-should-i-use" 
///target="_blank">Learn more</a>.</p></div>
/// <div class="note"><h4>Script tag deprecation</h4>
///   <p>Script tags will be sunset for the <b>Order status</b> page on August 28, 2025. <a 
///href="https://www.shopify.com/plus/upgrading-to-checkout-extensibility">Upgrade
/// to Checkout Extensibility</a> before this date. <a 
///href="/docs/api/liquid/objects#script">Shopify Scripts</a> will continue to work
/// alongside Checkout Extensibility until August 28, 2025.</p></div>
/// A script tag represents remote JavaScript code that is loaded into the pages of
/// a shop's storefront or the **Order status** page of checkout.
/// </summary>
public record ScriptTag : IGraphQLObject, ILegacyInteroperability, INode
{
    /// <summary>
    /// Whether the Shopify CDN can cache and serve the script tag.
    /// If `true`, then the script will be cached and served by the CDN.
    /// The cache expires 15 minutes after the script tag is successfully returned.
    /// If `false`, then the script will be served as is.
    /// </summary>
    [JsonPropertyName("cache")]
    public bool? cache { get; set; } = null;

    /// <summary>
    /// The date and time when the script tag was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The page or pages on the online store that the script should be included.
    /// </summary>
    [JsonPropertyName("displayScope")]
    public ScriptTagDisplayScope? displayScope { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The URL to the remote script.
    /// </summary>
    [JsonPropertyName("src")]
    public string? src { get; set; } = null;

    /// <summary>
    /// The date and time when the script tag was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}