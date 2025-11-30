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
/// Possible error codes that can be returned by `CustomerSetUserError`.
/// </summary>
public enum CustomerSetUserErrorCode
{
    INVALID,
    INCLUSION,
    TAKEN,
    TOO_LONG,
    TOO_SHORT,
    PRESENT,
    BLANK,
    ID_NOT_ALLOWED,
    MISSING_FIELD_REQUIRED,
    INPUT_MISMATCH,
    NOT_FOUND,
    METAFIELD_MISMATCH,
}