#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a recurring selling plan billing policy.
/// </summary>
public record SellingPlanRecurringBillingPolicy : SellingPlanBillingPolicy, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Specific anchor dates upon which the billing interval calculations should be made.
    /// </summary>
    [JsonPropertyName("anchors")]
    public ICollection<SellingPlanAnchor>? anchors { get; set; } = null;

    /// <summary>
    /// The date and time when the selling plan billing policy was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The billing frequency, it can be either: day, week, month or year.
    /// </summary>
    [JsonPropertyName("interval")]
    public SellingPlanInterval? interval { get; set; } = null;

    /// <summary>
    /// The number of intervals between billings.
    /// </summary>
    [JsonPropertyName("intervalCount")]
    public int? intervalCount { get; set; } = null;

    /// <summary>
    /// Maximum number of billing iterations.
    /// </summary>
    [JsonPropertyName("maxCycles")]
    public int? maxCycles { get; set; } = null;

    /// <summary>
    /// Minimum number of billing iterations.
    /// </summary>
    [JsonPropertyName("minCycles")]
    public int? minCycles { get; set; } = null;
}