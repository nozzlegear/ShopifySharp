#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The value of the discount.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(AppSubscriptionDiscountValueAppSubscriptionDiscountAmount), typeDiscriminator: "AppSubscriptionDiscountAmount")]
[JsonDerivedType(typeof(AppSubscriptionDiscountValueAppSubscriptionDiscountPercentage), typeDiscriminator: "AppSubscriptionDiscountPercentage")]
public record AppSubscriptionDiscountValue : GraphQLObject<AppSubscriptionDiscountValue>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public AppSubscriptionDiscountAmount? AsAppSubscriptionDiscountAmount() => this is AppSubscriptionDiscountValueAppSubscriptionDiscountAmount wrapper ? wrapper.Value : null;
	public AppSubscriptionDiscountPercentage? AsAppSubscriptionDiscountPercentage() => this is AppSubscriptionDiscountValueAppSubscriptionDiscountPercentage wrapper ? wrapper.Value : null;
#endif
}