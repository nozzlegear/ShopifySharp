#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

internal record SubscriptionDiscountValueSubscriptionDiscountPercentageValue(SubscriptionDiscountPercentageValue Value) : SubscriptionDiscountValue;