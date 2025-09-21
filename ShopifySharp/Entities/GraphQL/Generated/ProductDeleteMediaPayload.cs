#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `productDeleteMedia` mutation.
/// </summary>
public record ProductDeleteMediaPayload : IGraphQLObject
{
    /// <summary>
    /// List of media IDs which were deleted.
    /// </summary>
    [JsonPropertyName("deletedMediaIds")]
    public ICollection<string>? deletedMediaIds { get; set; } = null;

    /// <summary>
    /// List of product image IDs which were deleted.
    /// </summary>
    [JsonPropertyName("deletedProductImageIds")]
    public ICollection<string>? deletedProductImageIds { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("mediaUserErrors")]
    public ICollection<MediaUserError>? mediaUserErrors { get; set; } = null;

    /// <summary>
    /// The product associated with the deleted media.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    [Obsolete("Use `mediaUserErrors` instead.")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}