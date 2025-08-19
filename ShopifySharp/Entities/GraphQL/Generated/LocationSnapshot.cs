#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A snapshot of location details including name and address captured at a specific
/// point in time. Refer to the parent model to know the lifecycle.
/// </summary>
public record LocationSnapshot : IGraphQLObject
{
    /// <summary>
    /// The address details of the location as they were when the snapshot was recorded.
    /// </summary>
    [JsonPropertyName("address")]
    public LocationAddress? address { get; set; } = null;

    /// <summary>
    /// A reference to the live Location object, if it still exists and is accessible.
    /// This provides current details of the location, which may differ from the
    /// snapshotted name and address.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// The name of the location as it was when the snapshot was recorded.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The date and time when these snapshot details (name and address) were recorded.
    /// </summary>
    [JsonPropertyName("snapshottedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? snapshottedAt { get; set; } = null;
}