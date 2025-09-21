#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The valid types of actions a user should be able to perform in an financial app.
/// </summary>
public enum BankingFinanceAppAccess
{
    READ_ACCESS,
    MOVE_MONEY,
    MONEY_MOVEMENT_RESTRICTED,
    MONEY_MOVEMENT_BLOCKED_MFA,
}