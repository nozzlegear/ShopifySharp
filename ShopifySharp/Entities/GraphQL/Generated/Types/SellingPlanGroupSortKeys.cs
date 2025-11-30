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
/// The set of valid sort keys for the SellingPlanGroup query.
/// </summary>
public enum SellingPlanGroupSortKeys
{
    CREATED_AT,
    ID,
    NAME,
    UPDATED_AT,
}