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
/// Localized display text shown in place of a null cell in a ShopifyQL result row.
/// </summary>
public record ShopifyqlNullCellTranslation : IGraphQLObject
{
    /// <summary>
    /// The name of the column the translation applies to.
    /// </summary>
    [JsonPropertyName("columnName")]
    public string? columnName { get; set; } = null;

    /// <summary>
    /// The localized text to display in place of the null value.
    /// </summary>
    [JsonPropertyName("displayText")]
    public string? displayText { get; set; } = null;
}