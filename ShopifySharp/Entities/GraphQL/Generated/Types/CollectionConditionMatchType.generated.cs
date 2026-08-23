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
/// Specifies whether products must match any or all conditions to be included in the collection.
/// </summary>
public enum CollectionConditionMatchType
{
    ANY,
    ALL,
}