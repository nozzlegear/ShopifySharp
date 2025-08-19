#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `draftOrderInvoicePreview` mutation.
/// </summary>
public record DraftOrderInvoicePreviewPayload : IGraphQLObject
{
    /// <summary>
    /// The draft order invoice email rendered as HTML to allow previewing.
    /// </summary>
    [JsonPropertyName("previewHtml")]
    public string? previewHtml { get; set; } = null;

    /// <summary>
    /// The subject preview for the draft order invoice email.
    /// </summary>
    [JsonPropertyName("previewSubject")]
    public string? previewSubject { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}