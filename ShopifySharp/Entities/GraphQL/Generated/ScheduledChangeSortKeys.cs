#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The set of valid sort keys for the ScheduledChange query.
/// </summary>
public enum ScheduledChangeSortKeys
{
    EXPECTED_AT,
    ID,
}