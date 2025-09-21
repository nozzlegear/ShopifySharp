#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `privacyFeaturesDisable` mutation.
/// </summary>
public record PrivacyFeaturesDisablePayload : IGraphQLObject
{
    /// <summary>
    /// The privacy features that were disabled.
    /// </summary>
    [JsonPropertyName("featuresDisabled")]
    public ICollection<PrivacyFeaturesEnum>? featuresDisabled { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PrivacyFeaturesDisableUserError>? userErrors { get; set; } = null;
}