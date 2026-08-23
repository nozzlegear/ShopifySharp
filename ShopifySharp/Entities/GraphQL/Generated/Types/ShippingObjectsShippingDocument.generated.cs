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
/// Represents a shipping document.
/// </summary>
public record ShippingObjectsShippingDocument : IGraphQLObject
{
    /// <summary>
    /// The type of the shipping document.
    /// </summary>
    [JsonPropertyName("documentType")]
    public ShippingDocumentType? documentType { get; set; } = null;

    /// <summary>
    /// File format of the shipping document.
    /// </summary>
    [JsonPropertyName("format")]
    public ShippingEnumsFileFormat? format { get; set; } = null;

    /// <summary>
    /// The last time the document was printed.
    /// </summary>
    [JsonPropertyName("printedAt")]
    public DateTimeOffset? printedAt { get; set; } = null;

    /// <summary>
    /// The shipping label associated with the shipping document.
    /// </summary>
    [JsonPropertyName("shippingLabelId")]
    public string? shippingLabelId { get; set; } = null;

    /// <summary>
    /// URL of the shipping document.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}