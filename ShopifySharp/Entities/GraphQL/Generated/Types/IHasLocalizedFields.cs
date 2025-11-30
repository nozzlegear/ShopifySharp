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
/// Localized fields associated with the specified resource.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DraftOrder), typeDiscriminator: "DraftOrder")]
[JsonDerivedType(typeof(Order), typeDiscriminator: "Order")]
public interface IHasLocalizedFields : IGraphQLObject
{
    /// <summary>
    /// List of localized fields for the resource.
    /// </summary>
    [JsonPropertyName("localizedFields")]
    public LocalizedFieldConnection? localizedFields { get; set; }
}