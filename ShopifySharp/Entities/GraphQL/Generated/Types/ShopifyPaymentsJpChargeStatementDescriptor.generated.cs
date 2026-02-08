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
/// The charge descriptors for a Japanese payments account.
/// </summary>
public record ShopifyPaymentsJpChargeStatementDescriptor : IGraphQLObject, IShopifyPaymentsChargeStatementDescriptor
{
    /// <summary>
    /// The default charge statement descriptor.
    /// </summary>
    [JsonPropertyName("default")]
    public string? @default { get; set; } = null;

    /// <summary>
    /// The charge statement descriptor in kana.
    /// </summary>
    [JsonPropertyName("kana")]
    public string? kana { get; set; } = null;

    /// <summary>
    /// The charge statement descriptor in kanji.
    /// </summary>
    [JsonPropertyName("kanji")]
    public string? kanji { get; set; } = null;

    /// <summary>
    /// The prefix of the statement descriptor.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? prefix { get; set; } = null;
}