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
/// Represents an object that has a list of events.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
public interface IHasEvents : IGraphQLObject
{
    /// <summary>
    /// The paginated list of events associated with the host subject.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; }
}