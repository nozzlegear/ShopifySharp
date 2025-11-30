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

public class CustomersCountQueryBuilder() : GraphQueryBuilder<Count>("customersCount"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public CustomersCountQueryBuilder AddArgumentLimit(int? limit)
    {
        AddArgument("limit", limit);
        return this;
    }

    public CustomersCountQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }
}