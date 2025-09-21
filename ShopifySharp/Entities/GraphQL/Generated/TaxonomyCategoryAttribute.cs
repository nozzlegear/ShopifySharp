#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A product taxonomy attribute interface.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<TaxonomyCategoryAttribute>))]
public record TaxonomyCategoryAttribute : GraphQLObject<TaxonomyCategoryAttribute>, IGraphQLUnionType
{
    public TaxonomyAttribute? AsTaxonomyAttribute() => this is TaxonomyCategoryAttributeTaxonomyAttribute wrapper ? wrapper.Value : null;
    public TaxonomyChoiceListAttribute? AsTaxonomyChoiceListAttribute() => this is TaxonomyCategoryAttributeTaxonomyChoiceListAttribute wrapper ? wrapper.Value : null;
    public TaxonomyMeasurementAttribute? AsTaxonomyMeasurementAttribute() => this is TaxonomyCategoryAttributeTaxonomyMeasurementAttribute wrapper ? wrapper.Value : null;
}