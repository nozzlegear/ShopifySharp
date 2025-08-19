#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a session preceding an order, often used for building a timeline of events leading to an order.
/// </summary>
public interface ICustomerMoment : IGraphQLObject
{
    /// <summary>
    /// The date and time when the customer's session occurred.
    /// </summary>
    [JsonPropertyName("occurredAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? occurredAt { get; set; }
}