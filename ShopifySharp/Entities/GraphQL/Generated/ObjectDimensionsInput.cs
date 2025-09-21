#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for dimensions of an object.
/// </summary>
public record ObjectDimensionsInput : GraphQLInputObject<ObjectDimensionsInput>
{
    /// <summary>
    /// The height in `unit`s.
    /// </summary>
    [JsonPropertyName("height")]
    public decimal? height { get; set; } = null;

    /// <summary>
    /// The length in `unit`s.
    /// </summary>
    [JsonPropertyName("length")]
    public decimal? length { get; set; } = null;

    /// <summary>
    /// Unit of measurement for `length`, `width`, and `height`.
    /// </summary>
    [JsonPropertyName("unit")]
    public LengthUnit? unit { get; set; } = null;

    /// <summary>
    /// The width in `unit`s.
    /// </summary>
    [JsonPropertyName("width")]
    public decimal? width { get; set; } = null;
}