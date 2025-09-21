#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An agreement between the merchant and customer for a return.
/// </summary>
public record ReturnAgreement : IGraphQLObject, ISalesAgreement
{
    /// <summary>
    /// The application that created the agreement.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The date and time at which the agreement occured.
    /// </summary>
    [JsonPropertyName("happenedAt")]
    public DateTime? happenedAt { get; set; } = null;

    /// <summary>
    /// The unique ID for the agreement.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The reason the agremeent was created.
    /// </summary>
    [JsonPropertyName("reason")]
    public OrderActionType? reason { get; set; } = null;

    /// <summary>
    /// The return associated with the agreement.
    /// </summary>
    [JsonPropertyName("return")]
    public Return? @return { get; set; } = null;

    /// <summary>
    /// The sales associated with the agreement.
    /// </summary>
    [JsonPropertyName("sales")]
    public SaleConnection? sales { get; set; } = null;

    /// <summary>
    /// The staff member associated with the agreement.
    /// </summary>
    [JsonPropertyName("user")]
    public StaffMember? user { get; set; } = null;
}