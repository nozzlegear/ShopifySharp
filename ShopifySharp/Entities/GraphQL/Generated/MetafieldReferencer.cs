#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Types of resources that may use metafields to reference other resources.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(AppInstallation), typeDiscriminator: "AppInstallation")]
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
[JsonDerivedType(typeof(DraftOrder), typeDiscriminator: "DraftOrder")]
[JsonDerivedType(typeof(FulfillmentOrder), typeDiscriminator: "FulfillmentOrder")]
[JsonDerivedType(typeof(Location), typeDiscriminator: "Location")]
[JsonDerivedType(typeof(Market), typeDiscriminator: "Market")]
[JsonDerivedType(typeof(Metaobject), typeDiscriminator: "Metaobject")]
[JsonDerivedType(typeof(Order), typeDiscriminator: "Order")]
[JsonDerivedType(typeof(Page), typeDiscriminator: "Page")]
[JsonDerivedType(typeof(PaymentCustomization), typeDiscriminator: "PaymentCustomization")]
[JsonDerivedType(typeof(Product), typeDiscriminator: "Product")]
[JsonDerivedType(typeof(ProductVariant), typeDiscriminator: "ProductVariant")]
[JsonDerivedType(typeof(Shop), typeDiscriminator: "Shop")]
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