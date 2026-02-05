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
/// Possible error codes that can be returned by `FulfillmentConstraintRuleUpdateUserError`.
/// </summary>
public enum FulfillmentConstraintRuleUpdateUserErrorCode
{
    NOT_FOUND,
    UNAUTHORIZED_APP_SCOPE,
}