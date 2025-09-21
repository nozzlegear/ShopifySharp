#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `TaxAppConfigureUserError`.
/// </summary>
public enum TaxAppConfigureUserErrorCode
{
    TAX_PARTNER_NOT_FOUND,
    TAX_PARTNER_STATE_UPDATE_FAILED,
    TAX_PARTNER_ALREADY_ACTIVE,
}