#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Types of resources that may use metafields to reference other resources.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(MetafieldReferencerAppInstallation), typeDiscriminator: "AppInstallation")]
[JsonDerivedType(typeof(MetafieldReferencerArticle), typeDiscriminator: "Article")]
[JsonDerivedType(typeof(MetafieldReferencerBlog), typeDiscriminator: "Blog")]
[JsonDerivedType(typeof(MetafieldReferencerCollection), typeDiscriminator: "Collection")]
[JsonDerivedType(typeof(MetafieldReferencerCompany), typeDiscriminator: "Company")]
[JsonDerivedType(typeof(MetafieldReferencerCompanyLocation), typeDiscriminator: "CompanyLocation")]
[JsonDerivedType(typeof(MetafieldReferencerCustomer), typeDiscriminator: "Customer")]
[JsonDerivedType(typeof(MetafieldReferencerDeliveryCustomization), typeDiscriminator: "DeliveryCustomization")]
[JsonDerivedType(typeof(MetafieldReferencerDiscountAutomaticNode), typeDiscriminator: "DiscountAutomaticNode")]
[JsonDerivedType(typeof(MetafieldReferencerDiscountCodeNode), typeDiscriminator: "DiscountCodeNode")]
[JsonDerivedType(typeof(MetafieldReferencerDiscountNode), typeDiscriminator: "DiscountNode")]
[JsonDerivedType(typeof(MetafieldReferencerDraftOrder), typeDiscriminator: "DraftOrder")]
[JsonDerivedType(typeof(MetafieldReferencerFulfillmentOrder), typeDiscriminator: "FulfillmentOrder")]
[JsonDerivedType(typeof(MetafieldReferencerLocation), typeDiscriminator: "Location")]
[JsonDerivedType(typeof(MetafieldReferencerMarket), typeDiscriminator: "Market")]
[JsonDerivedType(typeof(MetafieldReferencerMetaobject), typeDiscriminator: "Metaobject")]
[JsonDerivedType(typeof(MetafieldReferencerOrder), typeDiscriminator: "Order")]
[JsonDerivedType(typeof(MetafieldReferencerPage), typeDiscriminator: "Page")]
[JsonDerivedType(typeof(MetafieldReferencerPaymentCustomization), typeDiscriminator: "PaymentCustomization")]
[JsonDerivedType(typeof(MetafieldReferencerProduct), typeDiscriminator: "Product")]
[JsonDerivedType(typeof(MetafieldReferencerProductVariant), typeDiscriminator: "ProductVariant")]
[JsonDerivedType(typeof(MetafieldReferencerShop), typeDiscriminator: "Shop")]
public record MetafieldReferencer : GraphQLObject<MetafieldReferencer>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public AppInstallation? AsAppInstallation() => this is MetafieldReferencerAppInstallation wrapper ? wrapper.Value : null;
	public Article? AsArticle() => this is MetafieldReferencerArticle wrapper ? wrapper.Value : null;
	public Blog? AsBlog() => this is MetafieldReferencerBlog wrapper ? wrapper.Value : null;
	public Collection? AsCollection() => this is MetafieldReferencerCollection wrapper ? wrapper.Value : null;
	public Company? AsCompany() => this is MetafieldReferencerCompany wrapper ? wrapper.Value : null;
	public CompanyLocation? AsCompanyLocation() => this is MetafieldReferencerCompanyLocation wrapper ? wrapper.Value : null;
	public Customer? AsCustomer() => this is MetafieldReferencerCustomer wrapper ? wrapper.Value : null;
	public DeliveryCustomization? AsDeliveryCustomization() => this is MetafieldReferencerDeliveryCustomization wrapper ? wrapper.Value : null;
	public DiscountAutomaticNode? AsDiscountAutomaticNode() => this is MetafieldReferencerDiscountAutomaticNode wrapper ? wrapper.Value : null;
	public DiscountCodeNode? AsDiscountCodeNode() => this is MetafieldReferencerDiscountCodeNode wrapper ? wrapper.Value : null;
	public DiscountNode? AsDiscountNode() => this is MetafieldReferencerDiscountNode wrapper ? wrapper.Value : null;
	public DraftOrder? AsDraftOrder() => this is MetafieldReferencerDraftOrder wrapper ? wrapper.Value : null;
	public FulfillmentOrder? AsFulfillmentOrder() => this is MetafieldReferencerFulfillmentOrder wrapper ? wrapper.Value : null;
	public Location? AsLocation() => this is MetafieldReferencerLocation wrapper ? wrapper.Value : null;
	public Market? AsMarket() => this is MetafieldReferencerMarket wrapper ? wrapper.Value : null;
	public Metaobject? AsMetaobject() => this is MetafieldReferencerMetaobject wrapper ? wrapper.Value : null;
	public Order? AsOrder() => this is MetafieldReferencerOrder wrapper ? wrapper.Value : null;
	public Page? AsPage() => this is MetafieldReferencerPage wrapper ? wrapper.Value : null;
	public PaymentCustomization? AsPaymentCustomization() => this is MetafieldReferencerPaymentCustomization wrapper ? wrapper.Value : null;
	public Product? AsProduct() => this is MetafieldReferencerProduct wrapper ? wrapper.Value : null;
	public ProductVariant? AsProductVariant() => this is MetafieldReferencerProductVariant wrapper ? wrapper.Value : null;
	public Shop? AsShop() => this is MetafieldReferencerShop wrapper ? wrapper.Value : null;
#endif
}