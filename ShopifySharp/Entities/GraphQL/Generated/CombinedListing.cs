#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A combined listing of products.
/// </summary>
public record CombinedListing : IGraphQLObject
{
    /// <summary>
    /// A list of child products in the combined listing.
    /// </summary>
    [JsonPropertyName("combinedListingChildren")]
    public CombinedListingChildConnection? combinedListingChildren { get; set; } = null;

    /// <summary>
    /// The parent product.
    /// </summary>
    [JsonPropertyName("parentProduct")]
    public Product? parentProduct { get; set; } = null;
}