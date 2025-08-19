#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record DeliveryConditionCriteriaMoneyV2(MoneyV2 Value): DeliveryConditionCriteria;
internal record DeliveryConditionCriteriaWeight(Weight Value): DeliveryConditionCriteria;
#endif /// <summary>

/// The field type that the condition will be applied to.
/// </summary>
public enum DeliveryConditionField
{
    TOTAL_WEIGHT,
    TOTAL_PRICE,
}