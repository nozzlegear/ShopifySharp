#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record SubscriptionDeliveryOptionSubscriptionLocalDeliveryOption(SubscriptionLocalDeliveryOption Value): SubscriptionDeliveryOption;
internal record SubscriptionDeliveryOptionSubscriptionPickupOption(SubscriptionPickupOption Value): SubscriptionDeliveryOption;
internal record SubscriptionDeliveryOptionSubscriptionShippingOption(SubscriptionShippingOption Value): SubscriptionDeliveryOption;
#endif /// <summary>

/// The result of the query to fetch delivery options for the subscription contract.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(SubscriptionDeliveryOptionResultFailure), typeDiscriminator: "SubscriptionDeliveryOptionResultFailure")]
[JsonDerivedType(typeof(SubscriptionDeliveryOptionResultSuccess), typeDiscriminator: "SubscriptionDeliveryOptionResultSuccess")]
public record SubscriptionDeliveryOptionResult : GraphQLObject<SubscriptionDeliveryOptionResult>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public SubscriptionDeliveryOptionResultFailure? AsSubscriptionDeliveryOptionResultFailure() => this is SubscriptionDeliveryOptionResultSubscriptionDeliveryOptionResultFailure wrapper ? wrapper.Value : null;
	public SubscriptionDeliveryOptionResultSuccess? AsSubscriptionDeliveryOptionResultSuccess() => this is SubscriptionDeliveryOptionResultSubscriptionDeliveryOptionResultSuccess wrapper ? wrapper.Value : null;
#endif
}