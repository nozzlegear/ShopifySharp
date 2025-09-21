#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The type of value given to a customer when a discount is applied to an order.
/// For example, the application of the discount might give the customer a
/// percentage off a specified item. Alternatively, the application of the discount
/// might give the customer a monetary value in a given currency off an order.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<PricingValue>))]
public record PricingValue : GraphQLObject<PricingValue>, IGraphQLUnionType
{
    public MoneyV2? AsMoneyV2() => this is PricingValueMoneyV2 wrapper ? wrapper.Value : null;
    public PricingPercentageValue? AsPricingPercentageValue() => this is PricingValuePricingPercentageValue wrapper ? wrapper.Value : null;
}