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

public class CatalogContextUpdateQueryBuilder() : GraphQueryBuilder<CatalogContextUpdatePayload>("catalogContextUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CatalogContextUpdateQueryBuilder AddArgumentCatalogId(string? catalogId)
    {
        AddArgument("catalogId", catalogId);
        return this;
    }

    public CatalogContextUpdateQueryBuilder AddArgumentContextsToAdd(CatalogContextInput? contextsToAdd)
    {
        AddArgument("contextsToAdd", contextsToAdd);
        return this;
    }

    public CatalogContextUpdateQueryBuilder AddArgumentContextsToRemove(CatalogContextInput? contextsToRemove)
    {
        AddArgument("contextsToRemove", contextsToRemove);
        return this;
    }
}