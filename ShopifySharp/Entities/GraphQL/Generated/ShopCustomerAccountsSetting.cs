#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the shop's customer account requirement preference.
/// </summary>
public enum ShopCustomerAccountsSetting
{
    REQUIRED,
    OPTIONAL,
    DISABLED,
}