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
/// RSS feed provider details for blog syndication. This object contains the
/// location and path information for external feed services that were previously
/// integrated with the blog.
/// The `BlogFeed` object maintains the feed URL and path to ensure existing feed subscriptions continue working.
/// Use the `BlogFeed` object to:
/// - Access RSS feed provider configuration
/// - Retrieve feed location and path information
/// - Maintain existing feed syndication settings
/// > Note:
/// > This is a legacy feature. New integrations with external feed services are not supported.
/// </summary>
public record BlogFeed : IGraphQLObject
{
    /// <summary>
    /// Blog feed provider url.
    /// </summary>
    [JsonPropertyName("location")]
    public string? location { get; set; } = null;

    /// <summary>
    /// Blog feed provider path.
    /// </summary>
    [JsonPropertyName("path")]
    public string? path { get; set; } = null;
}