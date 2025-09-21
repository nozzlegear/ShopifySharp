#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `CustomerPaymentMethodRemoteUserError`.
/// </summary>
public enum CustomerPaymentMethodRemoteUserErrorCode
{
    INVALID,
    PRESENT,
    TAKEN,
    EXACTLY_ONE_REMOTE_REFERENCE_REQUIRED,
    AUTHORIZE_NET_NOT_ENABLED_FOR_SUBSCRIPTIONS,
    BRAINTREE_NOT_ENABLED_FOR_SUBSCRIPTIONS,
}