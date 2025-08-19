#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Subscription draft discount types.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(SubscriptionAppliedCodeDiscount), typeDiscriminator: "SubscriptionAppliedCodeDiscount")]
[JsonDerivedType(typeof(SubscriptionManualDiscount), typeDiscriminator: "SubscriptionManualDiscount")]
public record SubscriptionDiscount : GraphQLObject<SubscriptionDiscount>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public SubscriptionAppliedCodeDiscount? AsSubscriptionAppliedCodeDiscount() => this is SubscriptionDiscountSubscriptionAppliedCodeDiscount wrapper ? wrapper.Value : null;
	public SubscriptionManualDiscount? AsSubscriptionManualDiscount() => this is SubscriptionDiscountSubscriptionManualDiscount wrapper ? wrapper.Value : null;
#endif
}