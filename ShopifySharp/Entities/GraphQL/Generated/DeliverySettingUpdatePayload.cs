#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `deliverySettingUpdate` mutation.
/// </summary>
public record DeliverySettingUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated delivery shop level settings.
    /// </summary>
    [JsonPropertyName("setting")]
    public DeliverySetting? setting { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}