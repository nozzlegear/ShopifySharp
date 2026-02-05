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
/// Possible marketing states for the customer’s email address.
/// </summary>
public enum CustomerEmailAddressMarketingState
{
    INVALID,
    NOT_SUBSCRIBED,
    PENDING,
    SUBSCRIBED,
    UNSUBSCRIBED,
}