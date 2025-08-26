#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

internal record AppPricingDetailsAppRecurringPricing(AppRecurringPricing Value) : AppPricingDetails;