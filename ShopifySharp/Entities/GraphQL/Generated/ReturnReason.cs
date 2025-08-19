#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The reason for returning the return line item.
/// </summary>
public enum ReturnReason
{
    SIZE_TOO_SMALL,
    SIZE_TOO_LARGE,
    UNWANTED,
    NOT_AS_DESCRIBED,
    WRONG_ITEM,
    DEFECTIVE,
    STYLE,
    COLOR,
    OTHER,
    UNKNOWN,
}