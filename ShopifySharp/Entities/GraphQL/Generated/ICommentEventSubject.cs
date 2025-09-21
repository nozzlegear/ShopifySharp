#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The subject line of a comment event.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(Company), typeDiscriminator: "Company")]
[JsonDerivedType(typeof(CompanyLocation), typeDiscriminator: "CompanyLocation")]
[JsonDerivedType(typeof(Customer), typeDiscriminator: "Customer")]
[JsonDerivedType(typeof(DraftOrder), typeDiscriminator: "DraftOrder")]
[JsonDerivedType(typeof(InventoryTransfer), typeDiscriminator: "InventoryTransfer")]
[JsonDerivedType(typeof(Order), typeDiscriminator: "Order")]
[JsonDerivedType(typeof(PriceRule), typeDiscriminator: "PriceRule")]
public interface ICommentEventSubject : IGraphQLObject
{
    /// <summary>
    /// Whether the timeline subject has a timeline comment. If true, then a timeline comment exists.
    /// </summary>
    [JsonPropertyName("hasTimelineComment")]
    public bool? hasTimelineComment { get; set; }

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }
}