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
/// Return type for `orderEditAddCustomItem` mutation.
/// </summary>
public record OrderEditAddCustomItemPayload : IGraphQLObject
{
    /// <summary>
    /// The custom line item that will be added to the order based on the current edits.
    /// </summary>
    [JsonPropertyName("calculatedLineItem")]
    public CalculatedLineItem? calculatedLineItem { get; set; } = null;

    /// <summary>
    /// An order with the edits applied but not saved.
    /// </summary>
    [JsonPropertyName("calculatedOrder")]
    public CalculatedOrder? calculatedOrder { get; set; } = null;

    /// <summary>
    /// The order edit session with the edits applied but not saved.
    /// </summary>
    [JsonPropertyName("orderEditSession")]
    public OrderEditSession? orderEditSession { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}