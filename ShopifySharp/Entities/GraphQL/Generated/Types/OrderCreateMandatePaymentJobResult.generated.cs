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
/// A job result for tracking the status of a mandate payment request on an order.
/// </summary>
public record OrderCreateMandatePaymentJobResult : IGraphQLObject, IJobResult, INode
{
    /// <summary>
    /// This indicates if the job is still queued or has been run.
    /// </summary>
    [JsonPropertyName("done")]
    public bool? done { get; set; } = null;

    /// <summary>
    /// Returns any errors that occurred during the mandate payment.
    /// </summary>
    [JsonPropertyName("errors")]
    public ICollection<UserError>? errors { get; set; } = null;

    /// <summary>
    /// A globally-unique ID that's returned when running an asynchronous mutation.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The order associated with the mandate payment request.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The current status of the mandate payment request.
    /// </summary>
    [JsonPropertyName("status")]
    public OrderCreateMandatePaymentStatus? status { get; set; } = null;
}