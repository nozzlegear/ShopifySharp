#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The valid values for the state of a customer's account with a shop.
/// </summary>
public enum CustomerState
{
    DECLINED,
    DISABLED,
    ENABLED,
    INVITED,
}