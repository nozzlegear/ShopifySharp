#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Describes the delivery method to use to get the physical goods to the customer.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<SubscriptionDeliveryMethod>))]
public record SubscriptionDeliveryMethod : GraphQLObject<SubscriptionDeliveryMethod>, IGraphQLUnionType
{
    public SubscriptionDeliveryMethodLocalDelivery? AsSubscriptionDeliveryMethodLocalDelivery() => this is SubscriptionDeliveryMethodSubscriptionDeliveryMethodLocalDelivery wrapper ? wrapper.Value : null;
    public SubscriptionDeliveryMethodPickup? AsSubscriptionDeliveryMethodPickup() => this is SubscriptionDeliveryMethodSubscriptionDeliveryMethodPickup wrapper ? wrapper.Value : null;
    public SubscriptionDeliveryMethodShipping? AsSubscriptionDeliveryMethodShipping() => this is SubscriptionDeliveryMethodSubscriptionDeliveryMethodShipping wrapper ? wrapper.Value : null;
}