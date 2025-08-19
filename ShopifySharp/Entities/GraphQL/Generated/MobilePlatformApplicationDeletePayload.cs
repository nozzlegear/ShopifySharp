#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `mobilePlatformApplicationDelete` mutation.
/// </summary>
public record MobilePlatformApplicationDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the mobile platform application that was just deleted.
    /// </summary>
    [JsonPropertyName("deletedMobilePlatformApplicationId")]
    public string? deletedMobilePlatformApplicationId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MobilePlatformApplicationUserError>? userErrors { get; set; } = null;
}