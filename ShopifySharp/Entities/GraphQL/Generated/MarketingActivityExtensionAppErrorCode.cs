#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The error code resulted from the marketing activity extension integration.
/// </summary>
public enum MarketingActivityExtensionAppErrorCode
{
    NOT_ONBOARDED_ERROR,
    VALIDATION_ERROR,
    API_ERROR,
    PLATFORM_ERROR,
    INSTALL_REQUIRED_ERROR,
}