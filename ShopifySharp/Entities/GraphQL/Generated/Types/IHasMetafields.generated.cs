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
/// Represents information about the metafields associated to the specified resource.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(AppInstallation), typeDiscriminator: "AppInstallation")]
[JsonDerivedType(typeof(Article), typeDiscriminator: "Article")]
[JsonDerivedType(typeof(Blog), typeDiscriminator: "Blog")]
[JsonDerivedType(typeof(CartTransform), typeDiscriminator: "CartTransform")]
[JsonDerivedType(typeof(Collection), typeDiscriminator: "Collection")]
[JsonDerivedType(typeof(Company), typeDiscriminator: "Company")]
[JsonDerivedType(typeof(CompanyLocation), typeDiscriminator: "CompanyLocation")]
[JsonDerivedType(typeof(Customer), typeDiscriminator: "Customer")]
[JsonDerivedType(typeof(CustomerSegmentMember), typeDiscriminator: "CustomerSegmentMember")]
[JsonDerivedType(typeof(DeliveryCustomization), typeDiscriminator: "DeliveryCustomization")]
[JsonDerivedType(typeof(DiscountAutomaticNode), typeDiscriminator: "DiscountAutomaticNode")]
[JsonDerivedType(typeof(DiscountCodeNode), typeDiscriminator: "DiscountCodeNode")]
[JsonDerivedType(typeof(DiscountNode), typeDiscriminator: "DiscountNode")]
[JsonDerivedType(typeof(DraftOrder), typeDiscriminator: "DraftOrder")]
[JsonDerivedType(typeof(FulfillmentConstraintRule), typeDiscriminator: "FulfillmentConstraintRule")]
[JsonDerivedType(typeof(GiftCardCreditTransaction), typeDiscriminator: "GiftCardCreditTransaction")]
[JsonDerivedType(typeof(GiftCardDebitTransaction), typeDiscriminator: "GiftCardDebitTransaction")]
[JsonDerivedType(typeof(Image), typeDiscriminator: "Image")]
[JsonDerivedType(typeof(InventoryTransfer), typeDiscriminator: "InventoryTransfer")]
[JsonDerivedType(typeof(Location), typeDiscriminator: "Location")]
[JsonDerivedType(typeof(Market), typeDiscriminator: "Market")]
[JsonDerivedType(typeof(MediaImage), typeDiscriminator: "MediaImage")]
[JsonDerivedType(typeof(Order), typeDiscriminator: "Order")]
[JsonDerivedType(typeof(Page), typeDiscriminator: "Page")]
[JsonDerivedType(typeof(PaymentCustomization), typeDiscriminator: "PaymentCustomization")]
[JsonDerivedType(typeof(Product), typeDiscriminator: "Product")]
[JsonDerivedType(typeof(ProductVariant), typeDiscriminator: "ProductVariant")]
[JsonDerivedType(typeof(SellingPlan), typeDiscriminator: "SellingPlan")]
[JsonDerivedType(typeof(Shop), typeDiscriminator: "Shop")]
[JsonDerivedType(typeof(Validation), typeDiscriminator: "Validation")]
public interface IHasMetafields : IGraphQLObject
{
    /// <summary>
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    public Metafield? metafield { get; set; }

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; }
}