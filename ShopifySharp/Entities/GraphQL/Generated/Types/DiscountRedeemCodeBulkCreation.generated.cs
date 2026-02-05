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
/// The properties and status of a bulk discount redeem code creation operation.
/// </summary>
public record DiscountRedeemCodeBulkCreation : IGraphQLObject, INode
{
    /// <summary>
    /// The result of each code creation operation associated with the bulk creation
    /// operation including any errors that might have occurred during the operation.
    /// </summary>
    [JsonPropertyName("codes")]
    public DiscountRedeemCodeBulkCreationCodeConnection? codes { get; set; } = null;

    /// <summary>
    /// The number of codes to create.
    /// </summary>
    [JsonPropertyName("codesCount")]
    public int? codesCount { get; set; } = null;

    /// <summary>
    /// The date and time when the bulk creation was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The code discount associated with the created codes.
    /// </summary>
    [JsonPropertyName("discountCode")]
    public DiscountCodeNode? discountCode { get; set; } = null;

    /// <summary>
    /// Whether the bulk creation is still queued (`false`) or has been run (`true`).
    /// </summary>
    [JsonPropertyName("done")]
    public bool? done { get; set; } = null;

    /// <summary>
    /// The number of codes that weren't created successfully.
    /// </summary>
    [JsonPropertyName("failedCount")]
    public int? failedCount { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The number of codes created successfully.
    /// </summary>
    [JsonPropertyName("importedCount")]
    public int? importedCount { get; set; } = null;
}