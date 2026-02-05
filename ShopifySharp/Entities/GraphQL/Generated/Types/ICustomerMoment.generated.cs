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
/// Represents a session preceding an order, often used for building a timeline of events leading to an order.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CustomerVisit), typeDiscriminator: "CustomerVisit")]
public interface ICustomerMoment : IGraphQLObject
{
    /// <summary>
    /// The date and time when the customer's session occurred.
    /// </summary>
    [JsonPropertyName("occurredAt")]
    public DateTimeOffset? occurredAt { get; set; }
}