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
/// The input fields for removing an exchange line item from a return.
/// </summary>
public record ExchangeLineItemRemoveFromReturnInput : GraphQLInputObject<ExchangeLineItemRemoveFromReturnInput>
{
    /// <summary>
    /// The ID of the exchange line item to remove.
    /// </summary>
    [JsonPropertyName("exchangeLineItemId")]
    public string? exchangeLineItemId { get; set; } = null;

    /// <summary>
    /// The quantity of the associated exchange line item to be removed.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}