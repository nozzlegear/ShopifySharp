#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The permission required to access a Shopify Admin API or Storefront API resource
/// for a shop. Merchants grant access scopes that are requested by applications.
/// </summary>
public record AccessScope : IGraphQLObject
{
    /// <summary>
    /// A description of the actions that the access scope allows an app to perform.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// A readable string that represents the access scope. The string usually follows
    /// the format `{action}_{resource}`. `{action}` is `read` or `write`, and
    /// `{resource}` is the resource that the action can be performed on. `{action}`
    /// and `{resource}` are separated by an underscore. For example, `read_orders` or
    /// `write_products`.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;
}