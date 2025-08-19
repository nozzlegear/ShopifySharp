#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A request to import a [`URLRedirect`](https://shopify.dev/api/admin-graphql/latest/objects/UrlRedirect) object
/// into the Online Store channel. Apps can use this to query the state of an `UrlRedirectImport` request.
/// For more information, see [`url-redirect`](https://help.shopify.com/en/manual/online-store/menus-and-links/url-redirect)s.
/// </summary>
public record UrlRedirectImport : IGraphQLObject, INode
{
    /// <summary>
    /// The number of rows in the file.
    /// </summary>
    [JsonPropertyName("count")]
    public int? count { get; set; } = null;

    /// <summary>
    /// The number of redirects created from the import.
    /// </summary>
    [JsonPropertyName("createdCount")]
    public int? createdCount { get; set; } = null;

    /// <summary>
    /// The number of redirects that failed to be imported.
    /// </summary>
    [JsonPropertyName("failedCount")]
    public int? failedCount { get; set; } = null;

    /// <summary>
    /// Whether the import is finished.
    /// </summary>
    [JsonPropertyName("finished")]
    public bool? finished { get; set; } = null;

    /// <summary>
    /// The date and time when the import finished.
    /// </summary>
    [JsonPropertyName("finishedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? finishedAt { get; set; } = null;

    /// <summary>
    /// The ID of the `UrlRedirectImport` object.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// A list of up to three previews of the URL redirects to be imported.
    /// </summary>
    [JsonPropertyName("previewRedirects")]
    public ICollection<UrlRedirectImportPreview>? previewRedirects { get; set; } = null;

    /// <summary>
    /// The number of redirects updated during the import.
    /// </summary>
    [JsonPropertyName("updatedCount")]
    public int? updatedCount { get; set; } = null;
}