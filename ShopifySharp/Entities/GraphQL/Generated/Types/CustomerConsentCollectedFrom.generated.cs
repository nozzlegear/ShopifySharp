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
/// The source that collected the customer's consent to receive marketing materials.
/// </summary>
public enum CustomerConsentCollectedFrom
{
    SHOPIFY,
    OTHER,
}