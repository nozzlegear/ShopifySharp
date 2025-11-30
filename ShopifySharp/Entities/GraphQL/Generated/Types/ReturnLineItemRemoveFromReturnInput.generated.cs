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
/// The input fields for a removing a return line item from a return.
/// </summary>
public record ReturnLineItemRemoveFromReturnInput : GraphQLInputObject<ReturnLineItemRemoveFromReturnInput>
{
    /// <summary>
    /// The quantity of the associated return line item to be removed.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The ID of the return line item to remove.
    /// </summary>
    [JsonPropertyName("returnLineItemId")]
    public string? returnLineItemId { get; set; } = null;
}