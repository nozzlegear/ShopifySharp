#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The possible header alignments.
/// </summary>
public enum CheckoutBrandingHeaderAlignment
{
    START,
    CENTER,
    END,
}