#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The filters used in segment queries associated with a shop.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(SegmentAssociationFilter), typeDiscriminator: "SegmentAssociationFilter")]
[JsonDerivedType(typeof(SegmentBooleanFilter), typeDiscriminator: "SegmentBooleanFilter")]
[JsonDerivedType(typeof(SegmentDateFilter), typeDiscriminator: "SegmentDateFilter")]
[JsonDerivedType(typeof(SegmentEnumFilter), typeDiscriminator: "SegmentEnumFilter")]
[JsonDerivedType(typeof(SegmentEventFilter), typeDiscriminator: "SegmentEventFilter")]
[JsonDerivedType(typeof(SegmentFloatFilter), typeDiscriminator: "SegmentFloatFilter")]
[JsonDerivedType(typeof(SegmentIntegerFilter), typeDiscriminator: "SegmentIntegerFilter")]
[JsonDerivedType(typeof(SegmentStringFilter), typeDiscriminator: "SegmentStringFilter")]
public interface ISegmentFilter : IGraphQLObject
{
    /// <summary>
    /// The localized name of the filter.
    /// </summary>
    [JsonPropertyName("localizedName")]
    public string? localizedName { get; set; }

    /// <summary>
    /// Whether a file can have multiple values for a single customer.
    /// </summary>
    [JsonPropertyName("multiValue")]
    public bool? multiValue { get; set; }

    /// <summary>
    /// The query name of the filter.
    /// </summary>
    [JsonPropertyName("queryName")]
    public string? queryName { get; set; }
}