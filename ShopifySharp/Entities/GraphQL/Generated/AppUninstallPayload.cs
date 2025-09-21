#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `appUninstall` mutation.
/// </summary>
public record AppUninstallPayload : IGraphQLObject
{
    /// <summary>
    /// The uninstalled app.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<AppUninstallAppUninstallError>? userErrors { get; set; } = null;
}