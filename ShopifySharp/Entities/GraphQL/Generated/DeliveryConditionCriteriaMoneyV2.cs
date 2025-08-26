#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

internal record DeliveryConditionCriteriaMoneyV2(MoneyV2 Value) : DeliveryConditionCriteria;