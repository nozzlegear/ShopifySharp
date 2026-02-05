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
/// A standardized reason for returning an item.
/// - Shopify offers an expanded library of return reasons available to all merchants
/// - For each product, Shopify suggests a curated subset of reasons based on the product's category
/// - Suggested reasons aren't the only valid options. When creating a return via
/// the API, you can use any reason from the [full library](https://shopify.dev/docs/api/admin-graphql/latest/queries/returnReasonDefinitions).
/// </summary>
public record ReturnReasonDefinition : IGraphQLObject, INode
{
    /// <summary>
    /// Whether the return reason has been removed from taxonomy.
    /// Deleted reasons should not be presented to customers when creating new returns, but may still
    /// appear on existing returns that were created before the reason was deleted. This field enables
    /// graceful deprecation of return reasons without breaking historical data.
    /// </summary>
    [JsonPropertyName("deleted")]
    public bool? deleted { get; set; } = null;

    /// <summary>
    /// A unique, human-readable, stable identifier for the return reason.
    /// Example values include "arrived-late", "comfort", "too-tight", "color-too-bright", and "quality".
    /// The handle remains consistent across API versions and localizations, making it suitable for programmatic use.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The localized, user-facing name of the return reason.
    /// This field returns the reason name in the requested locale, automatically falling back to
    /// English if no translation is available. Use this field when displaying return reasons to
    /// customers or merchants.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}