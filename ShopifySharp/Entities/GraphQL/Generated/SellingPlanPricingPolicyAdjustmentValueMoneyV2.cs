#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

internal record SellingPlanPricingPolicyAdjustmentValueMoneyV2(MoneyV2 Value) : SellingPlanPricingPolicyAdjustmentValue;