#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The result of the query to fetch shipping options for the subscription contract.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(SubscriptionShippingOptionResultFailure), typeDiscriminator: "SubscriptionShippingOptionResultFailure")]
[JsonDerivedType(typeof(SubscriptionShippingOptionResultSuccess), typeDiscriminator: "SubscriptionShippingOptionResultSuccess")]
public record SubscriptionShippingOptionResult : GraphQLObject<SubscriptionShippingOptionResult>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public SubscriptionShippingOptionResultFailure? AsSubscriptionShippingOptionResultFailure() => this is SubscriptionShippingOptionResultSubscriptionShippingOptionResultFailure wrapper ? wrapper.Value : null;
	public SubscriptionShippingOptionResultSuccess? AsSubscriptionShippingOptionResultSuccess() => this is SubscriptionShippingOptionResultSubscriptionShippingOptionResultSuccess wrapper ? wrapper.Value : null;
#endif
}