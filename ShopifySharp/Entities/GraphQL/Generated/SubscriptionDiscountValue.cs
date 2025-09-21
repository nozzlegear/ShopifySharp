#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The value of the discount and how it will be applied.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<SubscriptionDiscountValue>))]
public record SubscriptionDiscountValue : GraphQLObject<SubscriptionDiscountValue>, IGraphQLUnionType
{
    public SubscriptionDiscountFixedAmountValue? AsSubscriptionDiscountFixedAmountValue() => this is SubscriptionDiscountValueSubscriptionDiscountFixedAmountValue wrapper ? wrapper.Value : null;
    public SubscriptionDiscountPercentageValue? AsSubscriptionDiscountPercentageValue() => this is SubscriptionDiscountValueSubscriptionDiscountPercentageValue wrapper ? wrapper.Value : null;
}