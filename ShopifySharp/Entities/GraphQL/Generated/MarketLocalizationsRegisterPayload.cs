#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `marketLocalizationsRegister` mutation.
/// </summary>
public record MarketLocalizationsRegisterPayload : IGraphQLObject
{
    /// <summary>
    /// The market localizations that were created or updated.
    /// </summary>
    [JsonPropertyName("marketLocalizations")]
    public ICollection<MarketLocalization>? marketLocalizations { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<TranslationUserError>? userErrors { get; set; } = null;
}