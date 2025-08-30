#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Interoperability metadata for types that directly correspond to a REST Admin API resource.
/// For example, on the Product type, LegacyInteroperability returns metadata for
/// the corresponding [Product
/// object](https://shopify.dev/api/admin-graphql/latest/objects/product) in the
/// REST Admin API.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(Customer), typeDiscriminator: "Customer")]
[JsonDerivedType(typeof(DraftOrder), typeDiscriminator: "DraftOrder")]
[JsonDerivedType(typeof(Fulfillment), typeDiscriminator: "Fulfillment")]
[JsonDerivedType(typeof(InventoryItem), typeDiscriminator: "InventoryItem")]
[JsonDerivedType(typeof(Location), typeDiscriminator: "Location")]
[JsonDerivedType(typeof(MarketingEvent), typeDiscriminator: "MarketingEvent")]
[JsonDerivedType(typeof(Metafield), typeDiscriminator: "Metafield")]
[JsonDerivedType(typeof(Order), typeDiscriminator: "Order")]
[JsonDerivedType(typeof(PriceRule), typeDiscriminator: "PriceRule")]
[JsonDerivedType(typeof(Product), typeDiscriminator: "Product")]
[JsonDerivedType(typeof(ProductVariant), typeDiscriminator: "ProductVariant")]
[JsonDerivedType(typeof(Refund), typeDiscriminator: "Refund")]
[JsonDerivedType(typeof(SavedSearch), typeDiscriminator: "SavedSearch")]
[JsonDerivedType(typeof(ScriptTag), typeDiscriminator: "ScriptTag")]
[JsonDerivedType(typeof(ShopifyPaymentsDispute), typeDiscriminator: "ShopifyPaymentsDispute")]
[JsonDerivedType(typeof(ShopifyPaymentsPayout), typeDiscriminator: "ShopifyPaymentsPayout")]
[JsonDerivedType(typeof(WebhookSubscription), typeDiscriminator: "WebhookSubscription")]
public interface ILegacyInteroperability : IGraphQLObject
{
    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; }
}