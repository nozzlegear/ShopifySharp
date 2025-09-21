#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A default cursor that you can use in queries to paginate your results. Each edge in a connection can
/// return a cursor, which is a reference to the edge's position in the connection. You can use an edge's cursor as
/// the starting point to retrieve the nodes before or after it in a connection.
/// To learn more about using cursor-based pagination, refer to
/// [Paginating results with GraphQL](https://shopify.dev/api/usage/pagination-graphql).
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(AbandonedCheckout), typeDiscriminator: "AbandonedCheckout")]
[JsonDerivedType(typeof(Article), typeDiscriminator: "Article")]
[JsonDerivedType(typeof(Company), typeDiscriminator: "Company")]
[JsonDerivedType(typeof(CompanyLocation), typeDiscriminator: "CompanyLocation")]
[JsonDerivedType(typeof(CustomerAccountAppExtensionPage), typeDiscriminator: "CustomerAccountAppExtensionPage")]
[JsonDerivedType(typeof(CustomerAccountNativePage), typeDiscriminator: "CustomerAccountNativePage")]
[JsonDerivedType(typeof(DraftOrder), typeDiscriminator: "DraftOrder")]
[JsonDerivedType(typeof(Page), typeDiscriminator: "Page")]
[JsonDerivedType(typeof(Product), typeDiscriminator: "Product")]
[JsonDerivedType(typeof(ProductVariant), typeDiscriminator: "ProductVariant")]
public interface INavigable : IGraphQLObject
{
    /// <summary>
    /// A default [cursor](https://shopify.dev/api/usage/pagination-graphql) that
    /// returns the single next record, sorted ascending by ID.
    /// </summary>
    [JsonPropertyName("defaultCursor")]
    public string? defaultCursor { get; set; }
}