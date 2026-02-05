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
/// The valid SMS marketing states for a customer’s phone number.
/// </summary>
public enum CustomerSmsMarketingState
{
    NOT_SUBSCRIBED,
    PENDING,
    SUBSCRIBED,
    UNSUBSCRIBED,
    REDACTED,
}