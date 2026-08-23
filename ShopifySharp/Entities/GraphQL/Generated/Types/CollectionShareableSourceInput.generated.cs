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
/// The input fields for linking an existing shareable source to a collection.
/// </summary>
public record CollectionShareableSourceInput : GraphQLInputObject<CollectionShareableSourceInput>
{
    /// <summary>
    /// The ID of an existing shareable source to link to the collection.
    /// </summary>
    [JsonPropertyName("sourceId")]
    public string? sourceId { get; set; } = null;
}