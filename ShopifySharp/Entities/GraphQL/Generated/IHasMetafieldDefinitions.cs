#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Resources that metafield definitions can be applied to.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(Article), typeDiscriminator: "Article")]
[JsonDerivedType(typeof(Blog), typeDiscriminator: "Blog")]
[JsonDerivedType(typeof(Collection), typeDiscriminator: "Collection")]
[JsonDerivedType(typeof(Company), typeDiscriminator: "Company")]
[JsonDerivedType(typeof(CompanyLocation), typeDiscriminator: "CompanyLocation")]
[JsonDerivedType(typeof(Customer), typeDiscriminator: "Customer")]
[JsonDerivedType(typeof(DeliveryCustomization), typeDiscriminator: "DeliveryCustomization")]
[JsonDerivedType(typeof(DiscountAutomaticNode), typeDiscriminator: "DiscountAutomaticNode")]
[JsonDerivedType(typeof(DiscountCodeNode), typeDiscriminator: "DiscountCodeNode")]
[JsonDerivedType(typeof(DiscountNode), typeDiscriminator: "DiscountNode")]
[JsonDerivedType(typeof(InventoryTransfer), typeDiscriminator: "InventoryTransfer")]
[JsonDerivedType(typeof(Location), typeDiscriminator: "Location")]
[JsonDerivedType(typeof(Market), typeDiscriminator: "Market")]
[JsonDerivedType(typeof(Order), typeDiscriminator: "Order")]
[JsonDerivedType(typeof(Page), typeDiscriminator: "Page")]
[JsonDerivedType(typeof(PaymentCustomization), typeDiscriminator: "PaymentCustomization")]
[JsonDerivedType(typeof(Product), typeDiscriminator: "Product")]
[JsonDerivedType(typeof(ProductVariant), typeDiscriminator: "ProductVariant")]
[JsonDerivedType(typeof(SellingPlan), typeDiscriminator: "SellingPlan")]
[JsonDerivedType(typeof(Shop), typeDiscriminator: "Shop")]
[JsonDerivedType(typeof(Validation), typeDiscriminator: "Validation")]
public interface IHasMetafieldDefinitions : IGraphQLObject
{
    /// <summary>
    /// List of metafield definitions.
    /// </summary>
    [JsonPropertyName("metafieldDefinitions")]
    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public MetafieldDefinitionConnection? metafieldDefinitions { get; set; }
}