#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Tracks an adjustment to the cash in a cash tracking session for a point of sale device over the course of a shift.
/// </summary>
public record CashTrackingAdjustment : IGraphQLObject, INode
{
    /// <summary>
    /// The amount of cash being added or removed.
    /// </summary>
    [JsonPropertyName("cash")]
    public MoneyV2? cash { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The note entered when the adjustment was made.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The staff member who made the adjustment.
    /// </summary>
    [JsonPropertyName("staffMember")]
    public StaffMember? staffMember { get; set; } = null;

    /// <summary>
    /// The time when the adjustment was made.
    /// </summary>
    [JsonPropertyName("time")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? time { get; set; } = null;
}