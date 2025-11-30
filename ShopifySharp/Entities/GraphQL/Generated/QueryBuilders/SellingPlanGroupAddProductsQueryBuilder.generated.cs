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

public class SellingPlanGroupAddProductsQueryBuilder() : GraphQueryBuilder<SellingPlanGroupAddProductsPayload>("sellingPlanGroupAddProducts"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public SellingPlanGroupAddProductsQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public SellingPlanGroupAddProductsQueryBuilder AddArgumentProductIds(ICollection<string>? productIds)
    {
        AddArgument("productIds", productIds);
        return this;
    }
}