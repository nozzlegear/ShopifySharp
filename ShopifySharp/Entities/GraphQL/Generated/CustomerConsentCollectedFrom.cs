#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The source that collected the customer's consent to receive marketing materials.
/// </summary>
public enum CustomerConsentCollectedFrom
{
    SHOPIFY,
    OTHER,
}