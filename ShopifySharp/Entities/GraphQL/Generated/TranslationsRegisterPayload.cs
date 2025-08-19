#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `translationsRegister` mutation.
/// </summary>
public record TranslationsRegisterPayload : IGraphQLObject
{
    /// <summary>
    /// The translations that were created or updated.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<TranslationUserError>? userErrors { get; set; } = null;
}