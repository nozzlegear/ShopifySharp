#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `translationsRemove` mutation.
/// </summary>
public record TranslationsRemovePayload : IGraphQLObject
{
    /// <summary>
    /// The translations that were deleted.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<TranslationUserError>? userErrors { get; set; } = null;
}