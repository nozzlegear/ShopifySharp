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

public class ProductVariantLeaveSellingPlanGroupsQueryBuilder() : GraphQueryBuilder<ProductVariantLeaveSellingPlanGroupsPayload>("productVariantLeaveSellingPlanGroups"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductVariantLeaveSellingPlanGroupsQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public ProductVariantLeaveSellingPlanGroupsQueryBuilder AddArgumentSellingPlanGroupIds(ICollection<string>? sellingPlanGroupIds)
    {
        AddArgument("sellingPlanGroupIds", sellingPlanGroupIds);
        return this;
    }
}