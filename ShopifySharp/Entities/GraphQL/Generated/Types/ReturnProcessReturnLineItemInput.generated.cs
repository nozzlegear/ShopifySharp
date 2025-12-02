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
/// The input fields for a return line item.
/// </summary>
public record ReturnProcessReturnLineItemInput : GraphQLInputObject<ReturnProcessReturnLineItemInput>
{
    /// <summary>
    /// The dispositions for the return line item.
    /// </summary>
    [JsonPropertyName("dispositions")]
    public ICollection<ReverseFulfillmentOrderDisposeInput>? dispositions { get; set; } = null;

    /// <summary>
    /// The ID of the return line item.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The quantity of the return line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}