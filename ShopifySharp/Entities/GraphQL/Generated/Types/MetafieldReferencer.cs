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
/// Types of resources that may use metafields to reference other resources.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<MetafieldReferencer>))]
public record MetafieldReferencer : GraphQLObject<MetafieldReferencer>, IGraphQLUnionType
{
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
}