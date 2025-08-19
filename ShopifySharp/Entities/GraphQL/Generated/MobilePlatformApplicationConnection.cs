#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record MobilePlatformApplicationAndroidApplication(AndroidApplication Value): MobilePlatformApplication;
internal record MobilePlatformApplicationAppleApplication(AppleApplication Value): MobilePlatformApplication;
#endif /// <summary>

/// An auto-generated type for paginating through multiple MobilePlatformApplications.
/// </summary>
public record MobilePlatformApplicationConnection : ConnectionWithNodesAndEdges<MobilePlatformApplication?>
{
}