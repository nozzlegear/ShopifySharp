#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The valid values for the address type of a company.
/// </summary>
public enum CompanyAddressType
{
    BILLING,
    SHIPPING,
}