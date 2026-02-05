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
/// Requirements that must be met before an app can be installed.
/// </summary>
public record FailedRequirement : IGraphQLObject
{
    /// <summary>
    /// Action to be taken to resolve a failed requirement, including URL link.
    /// </summary>
    [JsonPropertyName("action")]
    public NavigationItem? action { get; set; } = null;

    /// <summary>
    /// A concise set of copy strings to be displayed to merchants, to guide them in resolving problems your app
    /// encounters when trying to make use of their Shop and its resources.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}