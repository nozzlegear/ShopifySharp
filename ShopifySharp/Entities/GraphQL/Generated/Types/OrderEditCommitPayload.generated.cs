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
/// Return type for `orderEditCommit` mutation.
/// </summary>
public record OrderEditCommitPayload : IGraphQLObject
{
    /// <summary>
    /// The order with changes applied.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// Messages to display to the user after the staged changes are commmitted.
    /// </summary>
    [JsonPropertyName("successMessages")]
    public ICollection<string>? successMessages { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}