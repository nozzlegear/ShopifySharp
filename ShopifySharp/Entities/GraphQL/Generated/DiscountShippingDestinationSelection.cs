#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The type used to target the eligible countries of an order's shipping
/// destination for which the discount applies. For example, the discount might be
/// applicable when shipping to all countries, or only to a set of countries.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<DiscountShippingDestinationSelection>))]
public record DiscountShippingDestinationSelection : GraphQLObject<DiscountShippingDestinationSelection>, IGraphQLUnionType
{
    public DiscountCountries? AsDiscountCountries() => this is DiscountShippingDestinationSelectionDiscountCountries wrapper ? wrapper.Value : null;
    public DiscountCountryAll? AsDiscountCountryAll() => this is DiscountShippingDestinationSelectionDiscountCountryAll wrapper ? wrapper.Value : null;
}