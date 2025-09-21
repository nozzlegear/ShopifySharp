#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible values for the cart link content type for the header.
/// </summary>
public enum CheckoutBrandingCartLinkContentType
{
    ICON,
    IMAGE,
    TEXT,
}