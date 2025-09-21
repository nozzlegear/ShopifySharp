#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Subscription draft discount types.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<SubscriptionDiscount>))]
public record SubscriptionDiscount : GraphQLObject<SubscriptionDiscount>, IGraphQLUnionType
{
    public SubscriptionAppliedCodeDiscount? AsSubscriptionAppliedCodeDiscount() => this is SubscriptionDiscountSubscriptionAppliedCodeDiscount wrapper ? wrapper.Value : null;
    public SubscriptionManualDiscount? AsSubscriptionManualDiscount() => this is SubscriptionDiscountSubscriptionManualDiscount wrapper ? wrapper.Value : null;
}