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
/// Represents the shop's customer account requirement preference.
/// </summary>
public enum ShopCustomerAccountsSetting
{
    REQUIRED,
    OPTIONAL,
    DISABLED,
}