#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The value of the discount and how it will be applied.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(SubscriptionDiscountValueSubscriptionDiscountFixedAmountValue), typeDiscriminator: "SubscriptionDiscountFixedAmountValue")]
[JsonDerivedType(typeof(SubscriptionDiscountValueSubscriptionDiscountPercentageValue), typeDiscriminator: "SubscriptionDiscountPercentageValue")]
public record SubscriptionDiscountValue : GraphQLObject<SubscriptionDiscountValue>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public SubscriptionDiscountFixedAmountValue? AsSubscriptionDiscountFixedAmountValue() => this is SubscriptionDiscountValueSubscriptionDiscountFixedAmountValue wrapper ? wrapper.Value : null;
	public SubscriptionDiscountPercentageValue? AsSubscriptionDiscountPercentageValue() => this is SubscriptionDiscountValueSubscriptionDiscountPercentageValue wrapper ? wrapper.Value : null;
#endif
}