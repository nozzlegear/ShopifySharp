#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A list of collections that the discount can have as a prerequisite or a list of
/// collections to which the discount can be applied.
/// </summary>
public record DiscountCollections : DiscountItems, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The list of collections that the discount can have as a prerequisite or the
    /// list of collections to which the discount can be applied.
    /// </summary>
    [JsonPropertyName("collections")]
    public CollectionConnection? collections { get; set; } = null;
}