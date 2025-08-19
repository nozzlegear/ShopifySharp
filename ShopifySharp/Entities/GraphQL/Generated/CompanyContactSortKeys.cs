#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the CompanyContact query.
/// </summary>
public enum CompanyContactSortKeys
{
    COMPANY_ID,
    CREATED_AT,
    EMAIL,
    ID,
    NAME,
    NAME_EMAIL,
    RELEVANCE,
    TITLE,
    UPDATED_AT,
}