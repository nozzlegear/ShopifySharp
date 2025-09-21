#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `flowGenerateSignature` mutation.
/// </summary>
public record FlowGenerateSignaturePayload : IGraphQLObject
{
    /// <summary>
    /// The payload used to generate the signature.
    /// </summary>
    [JsonPropertyName("payload")]
    public string? payload { get; set; } = null;

    /// <summary>
    /// The generated signature.
    /// </summary>
    [JsonPropertyName("signature")]
    public string? signature { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}