#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for shop-level delivery settings.
/// </summary>
public record DeliverySettingInput : GraphQLInputObject<DeliverySettingInput>
{
    /// <summary>
    /// Whether legacy compatability mode is enabled for the multi-location delivery profiles feature.
    /// </summary>
    [JsonPropertyName("legacyModeProfiles")]
    public bool? legacyModeProfiles { get; set; } = null;
}