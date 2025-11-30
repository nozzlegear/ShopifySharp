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

public class ProductsCountQueryBuilder() : GraphQueryBuilder<Count>("productsCount"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public ProductsCountQueryBuilder AddArgumentLimit(int? limit)
    {
        AddArgument("limit", limit);
        return this;
    }

    public ProductsCountQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public ProductsCountQueryBuilder AddArgumentSavedSearchId(string? savedSearchId)
    {
        AddArgument("savedSearchId", savedSearchId);
        return this;
    }
}