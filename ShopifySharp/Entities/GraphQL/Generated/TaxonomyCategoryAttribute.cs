#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A product taxonomy attribute interface.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(TaxonomyAttribute), typeDiscriminator: "TaxonomyAttribute")]
[JsonDerivedType(typeof(TaxonomyChoiceListAttribute), typeDiscriminator: "TaxonomyChoiceListAttribute")]
[JsonDerivedType(typeof(TaxonomyMeasurementAttribute), typeDiscriminator: "TaxonomyMeasurementAttribute")]
public record TaxonomyCategoryAttribute : GraphQLObject<TaxonomyCategoryAttribute>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public TaxonomyAttribute? AsTaxonomyAttribute() => this is TaxonomyCategoryAttributeTaxonomyAttribute wrapper ? wrapper.Value : null;
	public TaxonomyChoiceListAttribute? AsTaxonomyChoiceListAttribute() => this is TaxonomyCategoryAttributeTaxonomyChoiceListAttribute wrapper ? wrapper.Value : null;
	public TaxonomyMeasurementAttribute? AsTaxonomyMeasurementAttribute() => this is TaxonomyCategoryAttributeTaxonomyMeasurementAttribute wrapper ? wrapper.Value : null;
#endif
}