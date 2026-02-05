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
/// The value (weight or price) that the condition field is compared to.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<DeliveryConditionCriteria>))]
public record DeliveryConditionCriteria : GraphQLObject<DeliveryConditionCriteria>, IGraphQLUnionType
{
    public MoneyV2? AsMoneyV2() => this is DeliveryConditionCriteriaMoneyV2 wrapper ? wrapper.Value : null;
    public Weight? AsWeight() => this is DeliveryConditionCriteriaWeight wrapper ? wrapper.Value : null;
}