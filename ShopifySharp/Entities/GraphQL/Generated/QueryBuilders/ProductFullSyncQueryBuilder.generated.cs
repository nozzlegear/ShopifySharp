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

public class ProductFullSyncQueryBuilder() : GraphQueryBuilder<ProductFullSyncPayload>("productFullSync"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductFullSyncQueryBuilder AddArgumentBeforeUpdatedAt(DateTime? beforeUpdatedAt)
    {
        AddArgument("beforeUpdatedAt", beforeUpdatedAt);
        return this;
    }

    public ProductFullSyncQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public ProductFullSyncQueryBuilder AddArgumentUpdatedAtSince(DateTime? updatedAtSince)
    {
        AddArgument("updatedAtSince", updatedAtSince);
        return this;
    }
}