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
/// The return label file information for a reverse delivery.
/// </summary>
public record ReverseDeliveryLabelV2 : IGraphQLObject
{
    /// <summary>
    /// The date and time when the reverse delivery label was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// A public link that can be used to download the label image.
    /// </summary>
    [JsonPropertyName("publicFileUrl")]
    public string? publicFileUrl { get; set; } = null;

    /// <summary>
    /// The date and time when the reverse delivery label was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}