#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The resource referenced by the metafield value.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(Collection), typeDiscriminator: "Collection")]
[JsonDerivedType(typeof(Company), typeDiscriminator: "Company")]
[JsonDerivedType(typeof(Customer), typeDiscriminator: "Customer")]
[JsonDerivedType(typeof(GenericFile), typeDiscriminator: "GenericFile")]
[JsonDerivedType(typeof(MediaImage), typeDiscriminator: "MediaImage")]
[JsonDerivedType(typeof(Metaobject), typeDiscriminator: "Metaobject")]
[JsonDerivedType(typeof(Model3d), typeDiscriminator: "Model3d")]
[JsonDerivedType(typeof(Order), typeDiscriminator: "Order")]
[JsonDerivedType(typeof(Page), typeDiscriminator: "Page")]
[JsonDerivedType(typeof(Product), typeDiscriminator: "Product")]
[JsonDerivedType(typeof(ProductVariant), typeDiscriminator: "ProductVariant")]
[JsonDerivedType(typeof(TaxonomyValue), typeDiscriminator: "TaxonomyValue")]
[JsonDerivedType(typeof(Video), typeDiscriminator: "Video")]
public record MetafieldReference : GraphQLObject<MetafieldReference>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public Collection? AsCollection() => this is MetafieldReferenceCollection wrapper ? wrapper.Value : null;
	public Company? AsCompany() => this is MetafieldReferenceCompany wrapper ? wrapper.Value : null;
	public Customer? AsCustomer() => this is MetafieldReferenceCustomer wrapper ? wrapper.Value : null;
	public GenericFile? AsGenericFile() => this is MetafieldReferenceGenericFile wrapper ? wrapper.Value : null;
	public MediaImage? AsMediaImage() => this is MetafieldReferenceMediaImage wrapper ? wrapper.Value : null;
	public Metaobject? AsMetaobject() => this is MetafieldReferenceMetaobject wrapper ? wrapper.Value : null;
	public Model3d? AsModel3d() => this is MetafieldReferenceModel3d wrapper ? wrapper.Value : null;
	public Order? AsOrder() => this is MetafieldReferenceOrder wrapper ? wrapper.Value : null;
	public Page? AsPage() => this is MetafieldReferencePage wrapper ? wrapper.Value : null;
	public Product? AsProduct() => this is MetafieldReferenceProduct wrapper ? wrapper.Value : null;
	public ProductVariant? AsProductVariant() => this is MetafieldReferenceProductVariant wrapper ? wrapper.Value : null;
	public TaxonomyValue? AsTaxonomyValue() => this is MetafieldReferenceTaxonomyValue wrapper ? wrapper.Value : null;
	public Video? AsVideo() => this is MetafieldReferenceVideo wrapper ? wrapper.Value : null;
#endif
}