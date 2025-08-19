#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `ProductVariantsBulkCreateUserError`.
/// </summary>
public enum ProductVariantsBulkCreateUserErrorCode
{
    INVALID_INPUT,
    PRODUCT_DOES_NOT_EXIST,
    NO_KEY_ON_CREATE,
    VARIANT_ALREADY_EXISTS,
    PRODUCT_SUSPENDED,
    GREATER_THAN_OR_EQUAL_TO,
    NEED_TO_ADD_OPTION_VALUES,
    OPTION_VALUES_FOR_NUMBER_OF_UNKNOWN_OPTIONS,
    TOO_MANY_INVENTORY_LOCATIONS,
    SUBSCRIPTION_VIOLATION,
    VARIANT_ALREADY_EXISTS_CHANGE_OPTION_VALUE,
    TRACKED_VARIANT_LOCATION_NOT_FOUND,
    MUST_BE_FOR_THIS_PRODUCT,
    NOT_DEFINED_FOR_SHOP,
    INVALID,
    NEGATIVE_PRICE_VALUE,
    UNSUPPORTED_COMBINED_LISTING_PARENT_OPERATION,
    CANNOT_SET_NAME_FOR_LINKED_OPTION_VALUE,
}