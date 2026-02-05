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
/// The method by which the price rule's value is allocated to its entitled items.
/// </summary>
public enum PriceRuleAllocationMethod
{
    EACH,
    ACROSS,
}