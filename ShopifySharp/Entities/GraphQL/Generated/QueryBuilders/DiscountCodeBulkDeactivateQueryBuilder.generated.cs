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

public class DiscountCodeBulkDeactivateQueryBuilder() : GraphQueryBuilder<DiscountCodeBulkDeactivatePayload>("discountCodeBulkDeactivate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public DiscountCodeBulkDeactivateQueryBuilder AddArgumentIds(ICollection<string>? ids)
    {
        AddArgument("ids", ids);
        return this;
    }

    public DiscountCodeBulkDeactivateQueryBuilder AddArgumentSavedSearchId(string? savedSearchId)
    {
        AddArgument("savedSearchId", savedSearchId);
        return this;
    }

    public DiscountCodeBulkDeactivateQueryBuilder AddArgumentSearch(string? search)
    {
        AddArgument("search", search);
        return this;
    }
}