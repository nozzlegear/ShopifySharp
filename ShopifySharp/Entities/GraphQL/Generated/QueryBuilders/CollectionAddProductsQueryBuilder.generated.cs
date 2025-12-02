#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CollectionAddProductsQueryBuilder() : GraphQueryBuilder<CollectionAddProductsPayload>("collectionAddProducts"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CollectionAddProductsQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public CollectionAddProductsQueryBuilder AddArgumentProductIds(ICollection<string>? productIds)
    {
        AddArgument("productIds", productIds);
        return this;
    }
}