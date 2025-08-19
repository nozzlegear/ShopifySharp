#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the mobile platform application platform type.
/// </summary>
public record MobilePlatformApplicationUpdateInput : GraphQLInputObject<MobilePlatformApplicationUpdateInput>
{
    /// <summary>
    /// Android based Mobile Platform Application.
    /// </summary>
    [JsonPropertyName("android")]
    public MobilePlatformApplicationUpdateAndroidInput? android { get; set; } = null;

    /// <summary>
    /// Apple based Mobile Platform Application.
    /// </summary>
    [JsonPropertyName("apple")]
    public MobilePlatformApplicationUpdateAppleInput? apple { get; set; } = null;
}