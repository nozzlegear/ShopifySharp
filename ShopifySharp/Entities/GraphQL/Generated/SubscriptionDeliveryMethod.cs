#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Describes the delivery method to use to get the physical goods to the customer.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(SubscriptionDeliveryMethodLocalDelivery), typeDiscriminator: "SubscriptionDeliveryMethodLocalDelivery")]
[JsonDerivedType(typeof(SubscriptionDeliveryMethodPickup), typeDiscriminator: "SubscriptionDeliveryMethodPickup")]
[JsonDerivedType(typeof(SubscriptionDeliveryMethodShipping), typeDiscriminator: "SubscriptionDeliveryMethodShipping")]
public record SubscriptionDeliveryMethod : GraphQLObject<SubscriptionDeliveryMethod>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public SubscriptionDeliveryMethodLocalDelivery? AsSubscriptionDeliveryMethodLocalDelivery() => this is SubscriptionDeliveryMethodSubscriptionDeliveryMethodLocalDelivery wrapper ? wrapper.Value : null;
	public SubscriptionDeliveryMethodPickup? AsSubscriptionDeliveryMethodPickup() => this is SubscriptionDeliveryMethodSubscriptionDeliveryMethodPickup wrapper ? wrapper.Value : null;
	public SubscriptionDeliveryMethodShipping? AsSubscriptionDeliveryMethodShipping() => this is SubscriptionDeliveryMethodSubscriptionDeliveryMethodShipping wrapper ? wrapper.Value : null;
#endif
}