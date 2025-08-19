#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Localized fields associated with the specified resource.
/// </summary>
public interface IHasLocalizedFields : IGraphQLObject
{
    /// <summary>
    /// List of localized fields for the resource.
    /// </summary>
    [JsonPropertyName("localizedFields")]
    public LocalizedFieldConnection? localizedFields { get; set; }
}