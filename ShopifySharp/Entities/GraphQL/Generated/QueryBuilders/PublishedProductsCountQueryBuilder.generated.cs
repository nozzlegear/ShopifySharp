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

public class PublishedProductsCountQueryBuilder() : GraphQueryBuilder<Count>("publishedProductsCount"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public PublishedProductsCountQueryBuilder AddArgumentLimit(int? limit)
    {
        AddArgument("limit", limit);
        return this;
    }

    public PublishedProductsCountQueryBuilder AddArgumentPublicationId(string? publicationId)
    {
        AddArgument("publicationId", publicationId);
        return this;
    }
}