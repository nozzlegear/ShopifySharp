#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A customer account page.
/// </summary>
public interface ICustomerAccountPage : IGraphQLObject
{
    /// <summary>
    /// A default [cursor](https://shopify.dev/api/usage/pagination-graphql) that
    /// returns the single next record, sorted ascending by ID.
    /// </summary>
    [JsonPropertyName("defaultCursor")]
    public string? defaultCursor { get; set; }

    /// <summary>
    /// A unique, human-friendly string for the customer account page.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; }

    /// <summary>
    /// The unique ID for the customer account page.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// The title of the customer account page.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; }
}