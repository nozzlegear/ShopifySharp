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
/// The input fields for updating a shareable collection source.
/// </summary>
public record CollectionUpdateConditionsSourceInput : GraphQLInputObject<CollectionUpdateConditionsSourceInput>
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
    public CollectionUpdateSourceExclusionInput? exclusion { get; set; } = null;

    /// <summary>
    /// The ID of the source to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The inclusion rules for the source.
    /// </summary>
    [JsonPropertyName("inclusion")]
    public CollectionUpdateSourceInclusionInput? inclusion { get; set; } = null;

    /// <summary>
    /// The title of the source.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}