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
/// Stable identifier for why a collection cannot be referenced as a sub-collection target.
/// </summary>
public enum SubCollectionIneligibleReason
{
    INVALID_COLLECTION_REFERENCE,
    SELF_REFERENCE,
    CHAIN_REFERENCE,
}