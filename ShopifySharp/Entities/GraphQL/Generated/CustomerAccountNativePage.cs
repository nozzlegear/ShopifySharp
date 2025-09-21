#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A native page for the customer account navigation menu.
/// </summary>
public record CustomerAccountNativePage : IGraphQLObject, ICustomerAccountPage, INavigable, INode
{
    /// <summary>
    /// A default [cursor](https://shopify.dev/api/usage/pagination-graphql) that
    /// returns the single next record, sorted ascending by ID.
    /// </summary>
    [JsonPropertyName("defaultCursor")]
    public string? defaultCursor { get; set; } = null;

    /// <summary>
    /// A unique, human-friendly string for the customer account page.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The unique ID for the customer account page.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The type of customer account native page.
    /// </summary>
    [JsonPropertyName("pageType")]
    public CustomerAccountNativePagePageType? pageType { get; set; } = null;

    /// <summary>
    /// The title of the customer account page.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}