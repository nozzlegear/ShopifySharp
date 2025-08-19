#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Localization extensions associated with the specified resource. For example, the tax id for government invoice.
/// </summary>
public interface IHasLocalizationExtensions : IGraphQLObject
{
    /// <summary>
    /// List of localization extensions for the resource.
    /// </summary>
    [JsonPropertyName("localizationExtensions")]
    [Obsolete("This connection will be removed in a future version. Use `localizedFields` instead.")]
    public LocalizationExtensionConnection? localizationExtensions { get; set; }
}