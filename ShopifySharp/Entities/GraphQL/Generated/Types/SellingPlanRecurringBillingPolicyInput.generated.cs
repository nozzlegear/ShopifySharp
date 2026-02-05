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
/// The input fields required to create or update a recurring billing policy.
/// </summary>
public record SellingPlanRecurringBillingPolicyInput : GraphQLInputObject<SellingPlanRecurringBillingPolicyInput>
{
    /// <summary>
    /// Specific anchor dates upon which the billing interval calculations should be made.
    /// </summary>
    [JsonPropertyName("anchors")]
    public ICollection<SellingPlanAnchorInput>? anchors { get; set; } = null;

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