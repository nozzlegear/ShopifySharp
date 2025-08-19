#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The status of the customer merge request.
/// </summary>
public enum CustomerMergeRequestStatus
{
    REQUESTED,
    IN_PROGRESS,
    COMPLETED,
    FAILED,
}