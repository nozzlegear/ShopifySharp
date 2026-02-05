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
/// The set of valid sort keys for the SubscriptionContracts query.
/// </summary>
public enum SubscriptionContractsSortKeys
{
    CREATED_AT,
    ID,
    STATUS,
    UPDATED_AT,
}