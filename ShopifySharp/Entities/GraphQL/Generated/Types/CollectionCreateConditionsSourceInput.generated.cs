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
/// The input fields required to create a collection source.
/// </summary>
public record CollectionCreateConditionsSourceInput : GraphQLInputObject<CollectionCreateConditionsSourceInput>
{
    /// <summary>
    /// An optional description of the source.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The exclusion rules for the source.
    /// </summary>
    [JsonPropertyName("exclusion")]
    public CollectionCreateSourceExclusionInput? exclusion { get; set; } = null;

    /// <summary>
    /// The inclusion rules for the source.
    /// </summary>
    [JsonPropertyName("inclusion")]
    public CollectionCreateSourceInclusionInput? inclusion { get; set; } = null;

    /// <summary>
    /// What granularity this source operates at. Defaults to PRODUCTS.
    /// </summary>
    [JsonPropertyName("targetType")]
    public CollectionSourceTargetType? targetType { get; set; } = null;

    /// <summary>
    /// The title of the source.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}