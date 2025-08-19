#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The login redirection target for customer accounts.
/// </summary>
public enum CustomerAccountsVersion
{
    CLASSIC,
    NEW_CUSTOMER_ACCOUNTS,
}