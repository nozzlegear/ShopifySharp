#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The resource referenced by the metafield value.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<MetafieldReference>))]
public record MetafieldReference : GraphQLObject<MetafieldReference>, IGraphQLUnionType
{
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
}