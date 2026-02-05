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
/// The type of page where a shareable price rule URL lands.
/// </summary>
public enum PriceRuleShareableUrlTargetType
{
    HOME,
    PRODUCT,
    COLLECTION,
}