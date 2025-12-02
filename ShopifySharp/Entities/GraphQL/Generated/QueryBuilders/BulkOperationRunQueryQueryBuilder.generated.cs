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

public class BulkOperationRunQueryQueryBuilder() : GraphQueryBuilder<BulkOperationRunQueryPayload>("bulkOperationRunQuery"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public BulkOperationRunQueryQueryBuilder AddArgumentGroupObjects(bool? groupObjects)
    {
        AddArgument("groupObjects", groupObjects);
        return this;
    }

    public BulkOperationRunQueryQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }
}