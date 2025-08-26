#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type used to target the eligible countries of an order's shipping
/// destination for which the discount applies. For example, the discount might be
/// applicable when shipping to all countries, or only to a set of countries.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DiscountShippingDestinationSelectionDiscountCountries), typeDiscriminator: "DiscountCountries")]
[JsonDerivedType(typeof(DiscountShippingDestinationSelectionDiscountCountryAll), typeDiscriminator: "DiscountCountryAll")]
public record DiscountShippingDestinationSelection : GraphQLObject<DiscountShippingDestinationSelection>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public DiscountCountries? AsDiscountCountries() => this is DiscountShippingDestinationSelectionDiscountCountries wrapper ? wrapper.Value : null;
	public DiscountCountryAll? AsDiscountCountryAll() => this is DiscountShippingDestinationSelectionDiscountCountryAll wrapper ? wrapper.Value : null;
#endif
}