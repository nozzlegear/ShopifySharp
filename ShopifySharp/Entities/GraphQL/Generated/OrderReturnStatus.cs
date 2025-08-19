#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The order's aggregated return status that's used for display purposes.
/// An order might have multiple returns, so this field communicates the prioritized return status.
/// The `OrderReturnStatus` enum is a supported filter parameter in the [`orders` query](https://shopify.dev/api/admin-graphql/latest/queries/orders#:~:text=reference_location_id-,return_status,-risk_level).
/// </summary>
public enum OrderReturnStatus
{
    IN_PROGRESS,
    INSPECTION_COMPLETE,
    NO_RETURN,
    RETURNED,
    RETURN_FAILED,
    RETURN_REQUESTED,
}