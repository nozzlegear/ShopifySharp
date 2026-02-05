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
/// The input fields for a mobile application platform type.
/// </summary>
public record MobilePlatformApplicationCreateInput : GraphQLInputObject<MobilePlatformApplicationCreateInput>
{
    /// <summary>
    /// Android based mobile platform application.
    /// </summary>
    [JsonPropertyName("android")]
    public MobilePlatformApplicationCreateAndroidInput? android { get; set; } = null;

    /// <summary>
    /// Apple based mobile platform application.
    /// </summary>
    [JsonPropertyName("apple")]
    public MobilePlatformApplicationCreateAppleInput? apple { get; set; } = null;
}