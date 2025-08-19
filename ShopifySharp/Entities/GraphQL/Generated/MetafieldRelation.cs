#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record MetafieldReferencerAppInstallation(AppInstallation Value): MetafieldReferencer;
internal record MetafieldReferencerArticle(Article Value): MetafieldReferencer;
internal record MetafieldReferencerBlog(Blog Value): MetafieldReferencer;
internal record MetafieldReferencerCollection(Collection Value): MetafieldReferencer;
internal record MetafieldReferencerCompany(Company Value): MetafieldReferencer;
internal record MetafieldReferencerCompanyLocation(CompanyLocation Value): MetafieldReferencer;
internal record MetafieldReferencerCustomer(Customer Value): MetafieldReferencer;
internal record MetafieldReferencerDeliveryCustomization(DeliveryCustomization Value): MetafieldReferencer;
internal record MetafieldReferencerDiscountAutomaticNode(DiscountAutomaticNode Value): MetafieldReferencer;
internal record MetafieldReferencerDiscountCodeNode(DiscountCodeNode Value): MetafieldReferencer;
internal record MetafieldReferencerDiscountNode(DiscountNode Value): MetafieldReferencer;
internal record MetafieldReferencerDraftOrder(DraftOrder Value): MetafieldReferencer;
internal record MetafieldReferencerFulfillmentOrder(FulfillmentOrder Value): MetafieldReferencer;
internal record MetafieldReferencerLocation(Location Value): MetafieldReferencer;
internal record MetafieldReferencerMarket(Market Value): MetafieldReferencer;
internal record MetafieldReferencerMetaobject(Metaobject Value): MetafieldReferencer;
internal record MetafieldReferencerOrder(Order Value): MetafieldReferencer;
internal record MetafieldReferencerPage(Page Value): MetafieldReferencer;
internal record MetafieldReferencerPaymentCustomization(PaymentCustomization Value): MetafieldReferencer;
internal record MetafieldReferencerProduct(Product Value): MetafieldReferencer;
internal record MetafieldReferencerProductVariant(ProductVariant Value): MetafieldReferencer;
internal record MetafieldReferencerShop(Shop Value): MetafieldReferencer;
#endif /// <summary>

/// Defines a relation between two resources via a reference metafield.
/// The referencer owns the joining field with a given namespace and key,
/// while the target is referenced by the field.
/// </summary>
public record MetafieldRelation : IGraphQLObject
{
    /// <summary>
    /// The key of the field making the reference.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The name of the field making the reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The namespace of the metafield making the reference, or type of the metaobject.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;

    /// <summary>
    /// The resource making the reference.
    /// </summary>
    [JsonPropertyName("referencer")]
    public MetafieldReferencer? referencer { get; set; } = null;

    /// <summary>
    /// The referenced resource.
    /// </summary>
    [JsonPropertyName("target")]
    [Obsolete("No longer supported. Access the object directly instead.")]
    public MetafieldReference? target { get; set; } = null;
}