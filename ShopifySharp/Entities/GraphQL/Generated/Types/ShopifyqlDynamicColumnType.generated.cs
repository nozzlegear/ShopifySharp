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
/// The kind of dynamically generated column.
/// </summary>
public enum ShopifyqlDynamicColumnType
{
    UNSPECIFIED,
    TOTALS,
    COMPARISON,
    PERCENT_CHANGE,
    COMPARISON_TOTALS,
    BENCHMARKS,
    BENCHMARK_TOTALS,
    CUMULATIVE,
    COMPARISON_CUMULATIVE,
    ATTRIBUTION,
    ATTRIBUTION_TOTALS,
    ATTRIBUTION_COMPARISON,
    ATTRIBUTION_PERCENT_CHANGE,
    ATTRIBUTION_COMPARISON_TOTALS,
    ATTRIBUTION_CUMULATIVE,
    ATTRIBUTION_COMPARISON_CUMULATIVE,
    ROLLOUT_RESULTS,
}