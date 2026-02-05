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
/// The types of behavior to use when updating inventory.
/// </summary>
public enum OrderCreateInputsInventoryBehavior
{
    BYPASS,
    DECREMENT_IGNORING_POLICY,
    DECREMENT_OBEYING_POLICY,
}