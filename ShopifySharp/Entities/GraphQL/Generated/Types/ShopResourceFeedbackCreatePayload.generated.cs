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
/// Return type for `shopResourceFeedbackCreate` mutation.
/// </summary>
public record ShopResourceFeedbackCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The shop feedback that's created.
    /// </summary>
    [JsonPropertyName("feedback")]
    public AppFeedback? feedback { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ShopResourceFeedbackCreateUserError>? userErrors { get; set; } = null;
}