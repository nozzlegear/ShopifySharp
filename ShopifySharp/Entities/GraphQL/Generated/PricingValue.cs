#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of value given to a customer when a discount is applied to an order.
/// For example, the application of the discount might give the customer a
/// percentage off a specified item. Alternatively, the application of the discount
/// might give the customer a monetary value in a given currency off an order.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(PricingValueMoneyV2), typeDiscriminator: "MoneyV2")]
[JsonDerivedType(typeof(PricingValuePricingPercentageValue), typeDiscriminator: "PricingPercentageValue")]
public record PricingValue : GraphQLObject<PricingValue>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public MoneyV2? AsMoneyV2() => this is PricingValueMoneyV2 wrapper ? wrapper.Value : null;
	public PricingPercentageValue? AsPricingPercentageValue() => this is PricingValuePricingPercentageValue wrapper ? wrapper.Value : null;
#endif
}