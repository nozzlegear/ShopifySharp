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
/// The input fields for shop-level delivery settings.
/// </summary>
public record DeliverySettingInput : GraphQLInputObject<DeliverySettingInput>
{
    /// <summary>
    /// Whether legacy compatability mode is enabled for the multi-location delivery
    /// profiles feature. Note: this field is effectively deprecated and will be
    /// removed in a future version of the API.
    /// </summary>
    [JsonPropertyName("legacyModeProfiles")]
    public bool? legacyModeProfiles { get; set; } = null;
}