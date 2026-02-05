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
/// Represents feedback from apps about a resource, and the steps required to set up the apps on the shop.
/// </summary>
public record ResourceFeedback : IGraphQLObject
{
    /// <summary>
    /// Feedback from an app about the steps a merchant needs to take to set up the app on their store.
    /// </summary>
    [JsonPropertyName("appFeedback")]
    [Obsolete("Use `details` instead.")]
    public ICollection<AppFeedback>? appFeedback { get; set; } = null;

    /// <summary>
    /// List of AppFeedback detailing issues regarding a resource.
    /// </summary>
    [JsonPropertyName("details")]
    public ICollection<AppFeedback>? details { get; set; } = null;

    /// <summary>
    /// Summary of resource feedback pertaining to the resource.
    /// </summary>
    [JsonPropertyName("summary")]
    public string? summary { get; set; } = null;
}