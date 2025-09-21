#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The types of the hard blockers preventing a customer from being merged to another customer.
/// </summary>
public enum CustomerMergeErrorFieldType
{
    DELETED_AT,
    REDACTED_AT,
    SUBSCRIPTIONS,
    MERGE_IN_PROGRESS,
    GIFT_CARDS,
    OVERRIDE_FIELDS,
    STORE_CREDIT,
    COMPANY_CONTACT,
    CUSTOMER_PAYMENT_METHODS,
    PENDING_DATA_REQUEST,
    MULTIPASS_IDENTIFIER,
}