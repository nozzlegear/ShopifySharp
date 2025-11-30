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

public class CatalogsCountQueryBuilder() : GraphQueryBuilder<Count>("catalogsCount"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public CatalogsCountQueryBuilder AddArgumentLimit(int? limit)
    {
        AddArgument("limit", limit);
        return this;
    }

    public CatalogsCountQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public CatalogsCountQueryBuilder AddArgumentType(CatalogType? type)
    {
        AddArgument("type", type);
        return this;
    }
}