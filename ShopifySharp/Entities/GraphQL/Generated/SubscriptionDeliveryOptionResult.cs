#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The result of the query to fetch delivery options for the subscription contract.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<SubscriptionDeliveryOptionResult>))]
public record SubscriptionDeliveryOptionResult : GraphQLObject<SubscriptionDeliveryOptionResult>, IGraphQLUnionType
{
    public SubscriptionDeliveryOptionResultFailure? AsSubscriptionDeliveryOptionResultFailure() => this is SubscriptionDeliveryOptionResultSubscriptionDeliveryOptionResultFailure wrapper ? wrapper.Value : null;
    public SubscriptionDeliveryOptionResultSuccess? AsSubscriptionDeliveryOptionResultSuccess() => this is SubscriptionDeliveryOptionResultSubscriptionDeliveryOptionResultSuccess wrapper ? wrapper.Value : null;
}