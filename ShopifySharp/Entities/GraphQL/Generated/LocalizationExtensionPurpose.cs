#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The purpose of a localization extension.
/// </summary>
public enum LocalizationExtensionPurpose
{
    SHIPPING,
    TAX,
}