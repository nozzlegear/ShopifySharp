#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The valid values for the address type of a company.
/// </summary>
public enum CompanyAddressType
{
    BILLING,
    SHIPPING,
}