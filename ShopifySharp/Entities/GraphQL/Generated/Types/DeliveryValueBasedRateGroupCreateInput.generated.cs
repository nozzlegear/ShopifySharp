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
/// The input fields for creating a rate group for a value-based shipping option.
/// </summary>
public record DeliveryValueBasedRateGroupCreateInput : GraphQLInputObject<DeliveryValueBasedRateGroupCreateInput>
{
    /// <summary>
    /// Collection and origin location conditions for this rate group.
    /// </summary>
    [JsonPropertyName("conditions")]
    public DeliveryRateConditionsCreateInput? conditions { get; set; } = null;

    /// <summary>
    /// The rates to create in this rate group.
    /// </summary>
    [JsonPropertyName("rates")]
    public ICollection<DeliveryValueBasedRateCreateInput>? rates { get; set; } = null;
}