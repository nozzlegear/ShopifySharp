#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The delivery option for a subscription contract.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<SubscriptionDeliveryOption>))]
public record SubscriptionDeliveryOption : GraphQLObject<SubscriptionDeliveryOption>, IGraphQLUnionType
{
    public SubscriptionLocalDeliveryOption? AsSubscriptionLocalDeliveryOption() => this is SubscriptionDeliveryOptionSubscriptionLocalDeliveryOption wrapper ? wrapper.Value : null;
    public SubscriptionPickupOption? AsSubscriptionPickupOption() => this is SubscriptionDeliveryOptionSubscriptionPickupOption wrapper ? wrapper.Value : null;
    public SubscriptionShippingOption? AsSubscriptionShippingOption() => this is SubscriptionDeliveryOptionSubscriptionShippingOption wrapper ? wrapper.Value : null;
}