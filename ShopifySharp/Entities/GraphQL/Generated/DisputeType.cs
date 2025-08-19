#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible types for a dispute.
/// </summary>
public enum DisputeType
{
    CHARGEBACK,
    INQUIRY,
}