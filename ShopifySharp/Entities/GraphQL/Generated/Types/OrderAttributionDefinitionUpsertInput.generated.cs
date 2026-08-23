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
/// The input fields for upserting an order attribution definition.
/// </summary>
public record OrderAttributionDefinitionUpsertInput : GraphQLInputObject<OrderAttributionDefinitionUpsertInput>
{
    /// <summary>
    /// A human-readable name for the definition, displayed in Shopify Admin and on order details.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// A unique identifier for the definition, scoped to the calling app on a single
    /// shop. Case insensitive. Used to match an existing definition when upserting.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Sanitized SVG content used as the icon for orders attributed to this
    /// definition. Must conform to the platform's SVG sanitization rules and a 0 0 20
    /// 20 viewbox. Omit this field to leave the existing icon unchanged on update, or
    /// pass `null` to clear it.
    /// </summary>
    [JsonPropertyName("icon")]
    public string? icon { get; set; } = null;
}