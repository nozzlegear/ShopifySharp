#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The different types of method definitions to filter by.
/// </summary>
public enum DeliveryMethodDefinitionType
{
    MERCHANT,
    PARTICIPANT,
}