#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The return label file information for a reverse delivery.
/// </summary>
public record ReverseDeliveryLabelV2 : IGraphQLObject
{
    /// <summary>
    /// The date and time when the reverse delivery label was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// A public link that can be used to download the label image.
    /// </summary>
    [JsonPropertyName("publicFileUrl")]
    public string? publicFileUrl { get; set; } = null;

    /// <summary>
    /// The date and time when the reverse delivery label was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;
}