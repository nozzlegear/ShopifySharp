#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The set of valid sort keys for the CompanyLocation query.
/// </summary>
public enum CompanyLocationSortKeys
{
    COMPANY_AND_LOCATION_NAME,
    COMPANY_ID,
    CREATED_AT,
    ID,
    NAME,
    RELEVANCE,
    UPDATED_AT,
}