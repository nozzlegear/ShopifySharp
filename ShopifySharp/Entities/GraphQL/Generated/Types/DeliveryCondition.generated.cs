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
/// A condition that must pass for a delivery method definition to be applied to an order.
/// </summary>
public record DeliveryCondition : IGraphQLObject, INode
{
    /// <summary>
    /// The value (weight or price) that the condition field is compared to.
    /// </summary>
    [JsonPropertyName("conditionCriteria")]
    public DeliveryConditionCriteria? conditionCriteria { get; set; } = null;

    /// <summary>
    /// The field to compare the criterion value against, using the operator.
    /// </summary>
    [JsonPropertyName("field")]
    public DeliveryConditionField? field { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The operator to compare the field and criterion value.
    /// </summary>
    [JsonPropertyName("operator")]
    public DeliveryConditionOperator? @operator { get; set; } = null;
}