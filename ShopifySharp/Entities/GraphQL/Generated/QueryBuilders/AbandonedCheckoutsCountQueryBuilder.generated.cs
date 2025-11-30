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

public class AbandonedCheckoutsCountQueryBuilder() : GraphQueryBuilder<Count>("abandonedCheckoutsCount"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public AbandonedCheckoutsCountQueryBuilder AddArgumentLimit(int? limit)
    {
        AddArgument("limit", limit);
        return this;
    }

    public AbandonedCheckoutsCountQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public AbandonedCheckoutsCountQueryBuilder AddArgumentSavedSearchId(string? savedSearchId)
    {
        AddArgument("savedSearchId", savedSearchId);
        return this;
    }
}