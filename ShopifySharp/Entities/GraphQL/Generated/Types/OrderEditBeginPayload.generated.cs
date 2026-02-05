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
/// Return type for `orderEditBegin` mutation.
/// </summary>
public record OrderEditBeginPayload : IGraphQLObject
{
    /// <summary>
    /// The order that will be edited.
    /// </summary>
    [JsonPropertyName("calculatedOrder")]
    public CalculatedOrder? calculatedOrder { get; set; } = null;

    /// <summary>
    /// The order edit session that was created.
    /// </summary>
    [JsonPropertyName("orderEditSession")]
    public OrderEditSession? orderEditSession { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}