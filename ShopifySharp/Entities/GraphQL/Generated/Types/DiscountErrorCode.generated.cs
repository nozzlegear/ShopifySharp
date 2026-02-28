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
/// Possible error codes that can be returned by `DiscountUserError`.
/// </summary>
public enum DiscountErrorCode
{
    BLANK,
    PRESENT,
    EQUAL_TO,
    GREATER_THAN,
    GREATER_THAN_OR_EQUAL_TO,
    INVALID,
    LESS_THAN_OR_EQUAL_TO,
    LESS_THAN,
    TAKEN,
    TOO_LONG,
    TOO_SHORT,
    INTERNAL_ERROR,
    TOO_MANY_ARGUMENTS,
    MISSING_ARGUMENT,
    ACTIVE_PERIOD_OVERLAP,
    END_DATE_BEFORE_START_DATE,
    EXCEEDED_MAX,
    MINIMUM_SUBTOTAL_AND_QUANTITY_RANGE_BOTH_PRESENT,
    VALUE_OUTSIDE_RANGE,
    CONFLICT,
    IMPLICIT_DUPLICATE,
    DUPLICATE,
    INCLUSION,
    INVALID_COMBINES_WITH_FOR_DISCOUNT_CLASS,
    INVALID_DISCOUNT_CLASS_FOR_PRICE_RULE,
    MAX_APP_DISCOUNTS,
    APPLIES_ON_NOTHING,
    RECURRING_CYCLE_LIMIT_NOT_A_VALID_INTEGER,
    MULTIPLE_RECURRING_CYCLE_LIMIT_FOR_NON_SUBSCRIPTION_ITEMS,
    MISSING_FUNCTION_IDENTIFIER,
    MULTIPLE_FUNCTION_IDENTIFIERS,
}