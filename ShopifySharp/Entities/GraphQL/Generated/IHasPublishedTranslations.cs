#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Published translations associated with the resource.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(Article), typeDiscriminator: "Article")]
[JsonDerivedType(typeof(Blog), typeDiscriminator: "Blog")]
[JsonDerivedType(typeof(Collection), typeDiscriminator: "Collection")]
[JsonDerivedType(typeof(CookieBanner), typeDiscriminator: "CookieBanner")]
[JsonDerivedType(typeof(Link), typeDiscriminator: "Link")]
[JsonDerivedType(typeof(Menu), typeDiscriminator: "Menu")]
[JsonDerivedType(typeof(OnlineStoreTheme), typeDiscriminator: "OnlineStoreTheme")]
[JsonDerivedType(typeof(Page), typeDiscriminator: "Page")]
[JsonDerivedType(typeof(Product), typeDiscriminator: "Product")]
[JsonDerivedType(typeof(ProductOption), typeDiscriminator: "ProductOption")]
[JsonDerivedType(typeof(ProductOptionValue), typeDiscriminator: "ProductOptionValue")]
[JsonDerivedType(typeof(ProductVariant), typeDiscriminator: "ProductVariant")]
[JsonDerivedType(typeof(SellingPlan), typeDiscriminator: "SellingPlan")]
[JsonDerivedType(typeof(SellingPlanGroup), typeDiscriminator: "SellingPlanGroup")]
[JsonDerivedType(typeof(Shop), typeDiscriminator: "Shop")]
[JsonDerivedType(typeof(ShopPolicy), typeDiscriminator: "ShopPolicy")]
public interface IHasPublishedTranslations : IGraphQLObject
{
    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; }
}