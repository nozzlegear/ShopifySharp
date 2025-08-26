#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

internal record PricingValueMoneyV2(MoneyV2 Value) : PricingValue;