#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record TaxonomyCategoryAttributeTaxonomyAttribute(TaxonomyAttribute Value): TaxonomyCategoryAttribute;
internal record TaxonomyCategoryAttributeTaxonomyChoiceListAttribute(TaxonomyChoiceListAttribute Value): TaxonomyCategoryAttribute;
internal record TaxonomyCategoryAttributeTaxonomyMeasurementAttribute(TaxonomyMeasurementAttribute Value): TaxonomyCategoryAttribute;
#endif /// <summary>

/// An auto-generated type for paginating through multiple TaxonomyCategoryAttributes.
/// </summary>
public record TaxonomyCategoryAttributeConnection : ConnectionWithNodesAndEdges<TaxonomyCategoryAttribute?>
{
}