#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents an object that has a list of events.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(Article), typeDiscriminator: "Article")]
[JsonDerivedType(typeof(Blog), typeDiscriminator: "Blog")]
[JsonDerivedType(typeof(Collection), typeDiscriminator: "Collection")]
[JsonDerivedType(typeof(Comment), typeDiscriminator: "Comment")]
[JsonDerivedType(typeof(Company), typeDiscriminator: "Company")]
[JsonDerivedType(typeof(CompanyLocation), typeDiscriminator: "CompanyLocation")]
[JsonDerivedType(typeof(Customer), typeDiscriminator: "Customer")]
[JsonDerivedType(typeof(DiscountAutomaticBxgy), typeDiscriminator: "DiscountAutomaticBxgy")]
[JsonDerivedType(typeof(DiscountAutomaticNode), typeDiscriminator: "DiscountAutomaticNode")]
[JsonDerivedType(typeof(DiscountCodeNode), typeDiscriminator: "DiscountCodeNode")]
[JsonDerivedType(typeof(DiscountNode), typeDiscriminator: "DiscountNode")]
[JsonDerivedType(typeof(DraftOrder), typeDiscriminator: "DraftOrder")]
[JsonDerivedType(typeof(InventoryTransfer), typeDiscriminator: "InventoryTransfer")]
[JsonDerivedType(typeof(Order), typeDiscriminator: "Order")]
[JsonDerivedType(typeof(Page), typeDiscriminator: "Page")]
[JsonDerivedType(typeof(PriceRule), typeDiscriminator: "PriceRule")]
[JsonDerivedType(typeof(Product), typeDiscriminator: "Product")]
[JsonDerivedType(typeof(ProductVariant), typeDiscriminator: "ProductVariant")]
public interface IHasEvents : IGraphQLObject
{
    /// <summary>
    /// The paginated list of events associated with the host subject.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; }
}