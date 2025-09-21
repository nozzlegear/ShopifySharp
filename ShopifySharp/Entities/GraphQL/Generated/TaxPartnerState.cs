#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// State of the tax app configuration.
/// </summary>
public enum TaxPartnerState
{
    PENDING,
    READY,
    ACTIVE,
}