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
/// The input fields for updating the condition of a delivery method definition.
/// </summary>
public record DeliveryUpdateConditionInput : GraphQLInputObject<DeliveryUpdateConditionInput>
{
    /// <summary>
    /// The value that will be used in comparison.
    /// </summary>
    [JsonPropertyName("criteria")]
    public decimal? criteria { get; set; } = null;

    /// <summary>
    /// The unit associated with the value that will be used in comparison.
    /// </summary>
    [JsonPropertyName("criteriaUnit")]
    public string? criteriaUnit { get; set; } = null;

    /// <summary>
    /// The property of an order that will be used in comparison.
    /// </summary>
    [JsonPropertyName("field")]
    public DeliveryConditionField? field { get; set; } = null;

    /// <summary>
    /// A globally-unique ID of the condition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The operator to use for comparison.
    /// </summary>
    [JsonPropertyName("operator")]
    public DeliveryConditionOperator? @operator { get; set; } = null;
}