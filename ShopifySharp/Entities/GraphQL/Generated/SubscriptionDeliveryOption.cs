#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The delivery option for a subscription contract.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(SubscriptionLocalDeliveryOption), typeDiscriminator: "SubscriptionLocalDeliveryOption")]
[JsonDerivedType(typeof(SubscriptionPickupOption), typeDiscriminator: "SubscriptionPickupOption")]
[JsonDerivedType(typeof(SubscriptionShippingOption), typeDiscriminator: "SubscriptionShippingOption")]
public record SubscriptionDeliveryOption : GraphQLObject<SubscriptionDeliveryOption>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public SubscriptionLocalDeliveryOption? AsSubscriptionLocalDeliveryOption() => this is SubscriptionDeliveryOptionSubscriptionLocalDeliveryOption wrapper ? wrapper.Value : null;
	public SubscriptionPickupOption? AsSubscriptionPickupOption() => this is SubscriptionDeliveryOptionSubscriptionPickupOption wrapper ? wrapper.Value : null;
	public SubscriptionShippingOption? AsSubscriptionShippingOption() => this is SubscriptionDeliveryOptionSubscriptionShippingOption wrapper ? wrapper.Value : null;
#endif
}