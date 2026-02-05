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
/// Return type for `marketLocalizationsRemove` mutation.
/// </summary>
public record MarketLocalizationsRemovePayload : IGraphQLObject
{
    /// <summary>
    /// The market localizations that were deleted.
    /// </summary>
    [JsonPropertyName("marketLocalizations")]
    public ICollection<MarketLocalization>? marketLocalizations { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<TranslationUserError>? userErrors { get; set; } = null;
}