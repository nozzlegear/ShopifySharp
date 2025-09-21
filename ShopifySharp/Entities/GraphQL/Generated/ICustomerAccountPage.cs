#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A customer account page.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CustomerAccountAppExtensionPage), typeDiscriminator: "CustomerAccountAppExtensionPage")]
[JsonDerivedType(typeof(CustomerAccountNativePage), typeDiscriminator: "CustomerAccountNativePage")]
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