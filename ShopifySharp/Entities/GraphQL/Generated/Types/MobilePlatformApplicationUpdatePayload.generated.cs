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
/// Return type for `mobilePlatformApplicationUpdate` mutation.
/// </summary>
public record MobilePlatformApplicationUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// Created mobile platform application.
    /// </summary>
    [JsonPropertyName("mobilePlatformApplication")]
    public MobilePlatformApplication? mobilePlatformApplication { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MobilePlatformApplicationUserError>? userErrors { get; set; } = null;
}