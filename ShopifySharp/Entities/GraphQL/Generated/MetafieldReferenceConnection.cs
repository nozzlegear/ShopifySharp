#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record MetafieldReferenceCollection(Collection Value): MetafieldReference;
internal record MetafieldReferenceCompany(Company Value): MetafieldReference;
internal record MetafieldReferenceCustomer(Customer Value): MetafieldReference;
internal record MetafieldReferenceGenericFile(GenericFile Value): MetafieldReference;
internal record MetafieldReferenceMediaImage(MediaImage Value): MetafieldReference;
internal record MetafieldReferenceMetaobject(Metaobject Value): MetafieldReference;
internal record MetafieldReferenceModel3d(Model3d Value): MetafieldReference;
internal record MetafieldReferenceOrder(Order Value): MetafieldReference;
internal record MetafieldReferencePage(Page Value): MetafieldReference;
internal record MetafieldReferenceProduct(Product Value): MetafieldReference;
internal record MetafieldReferenceProductVariant(ProductVariant Value): MetafieldReference;
internal record MetafieldReferenceTaxonomyValue(TaxonomyValue Value): MetafieldReference;
internal record MetafieldReferenceVideo(Video Value): MetafieldReference;
#endif /// <summary>

/// An auto-generated type for paginating through multiple MetafieldReferences.
/// </summary>
public record MetafieldReferenceConnection : ConnectionWithNodesAndEdges<MetafieldReference?>
{
}