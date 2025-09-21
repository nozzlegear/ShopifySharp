#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The result of the query to fetch shipping options for the subscription contract.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<SubscriptionShippingOptionResult>))]
public record SubscriptionShippingOptionResult : GraphQLObject<SubscriptionShippingOptionResult>, IGraphQLUnionType
{
    public SubscriptionShippingOptionResultFailure? AsSubscriptionShippingOptionResultFailure() => this is SubscriptionShippingOptionResultSubscriptionShippingOptionResultFailure wrapper ? wrapper.Value : null;
    public SubscriptionShippingOptionResultSuccess? AsSubscriptionShippingOptionResultSuccess() => this is SubscriptionShippingOptionResultSubscriptionShippingOptionResultSuccess wrapper ? wrapper.Value : null;
}