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
/// Return type for `blogCreate` mutation.
/// </summary>
public record BlogCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The blog that was created.
    /// </summary>
    [JsonPropertyName("blog")]
    public Blog? blog { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BlogCreateUserError>? userErrors { get; set; } = null;
}