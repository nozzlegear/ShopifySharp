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
/// Shared color customizations for semantic and functional colors.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingSharedColors : IGraphQLObject
{
    /// <summary>
    /// The accent color for interactive elements.
    /// </summary>
    [JsonPropertyName("accent")]
    public string? accent { get; set; } = null;

    /// <summary>
    /// The button color.
    /// </summary>
    [JsonPropertyName("button")]
    public string? button { get; set; } = null;

    /// <summary>
    /// The form control color.
    /// </summary>
    [JsonPropertyName("control")]
    public string? control { get; set; } = null;

    /// <summary>
    /// The critical/error color.
    /// </summary>
    [JsonPropertyName("critical")]
    public string? critical { get; set; } = null;

    /// <summary>
    /// The decorative color.
    /// </summary>
    [JsonPropertyName("decorative")]
    public string? decorative { get; set; } = null;

    /// <summary>
    /// The informational color.
    /// </summary>
    [JsonPropertyName("info")]
    public string? info { get; set; } = null;

    /// <summary>
    /// The success color.
    /// </summary>
    [JsonPropertyName("success")]
    public string? success { get; set; } = null;

    /// <summary>
    /// The warning color.
    /// </summary>
    [JsonPropertyName("warning")]
    public string? warning { get; set; } = null;
}