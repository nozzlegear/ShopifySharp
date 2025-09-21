#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The type of refund to perform for a particular refund duty.
/// </summary>
public enum RefundDutyRefundType
{
    PROPORTIONAL,
    FULL,
}