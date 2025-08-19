#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The value (weight or price) that the condition field is compared to.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(MoneyV2), typeDiscriminator: "MoneyV2")]
[JsonDerivedType(typeof(Weight), typeDiscriminator: "Weight")]
public record DeliveryConditionCriteria : GraphQLObject<DeliveryConditionCriteria>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public MoneyV2? AsMoneyV2() => this is DeliveryConditionCriteriaMoneyV2 wrapper ? wrapper.Value : null;
	public Weight? AsWeight() => this is DeliveryConditionCriteriaWeight wrapper ? wrapper.Value : null;
#endif
}